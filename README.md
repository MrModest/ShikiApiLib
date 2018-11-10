# Устарело
Библиотека более не поддерживается. В ней используется старый способ авторизации по логину и паролю, который уже не работает. 
Обновлять библиотеку я не планирую, т.к. код писался давно, опыта было мало, а копаться в старых макаронах нет ни времени, ни желания)

# ShikiApiLib
Реализация API сайта [***Shikimori***](https://shikimori.org/) на C#

Проект оформлен в виде **Библиотеки классов (переносимой для iOS, Android и Windows)**. 

Содержит в себе два основных класса <a target="_blank" href="Documentation/T_ShikiApiLib_ShikiApi.md"><strong>ShikiApi</strong></a> и <a target="_blank" href="Documentation/T_ShikiApiLib_ShikiApiStatic.md"><strong>ShikiApiStatic</strong></a>, которые позволяют общаться с сервером Shikimori.org

Небольшая оговорка по тексту ниже: тайтл - это либо аниме, либо манга. Термин включает в себя оба понятия. Также **все описанные ниже методы имеют аналоги работающие с мангой. Достаточно в названии метода или класса заменить "Anime" на "Manga".**

Если что-то в тексте непонятно или же у вас есть пожелания или советы, как его можно улучшить, то можете писать мне по следующим контактам:
- babaevkamil@gmail.com
- https://vk.com/mrm0dest
- https://shikimori.org/MrModest

## ShikiApi

Авторизация нового пользователя происходит посредством инициализации экземпляра класса <a target="_blank" href="Documentation/T_ShikiApiLib_ShikiApi.md"><strong>ShikiApi</strong></a>.

```C#
ShikiApi user = new ShikiApi("nickname", "password");
```
Далее всё ***авторизованное*** общение с сервером происходит через свойства и методы данного инициализированного экземпляра класса. 

#### Получить инфо о пользователе
К примеру, для получения подробной информации об авторизованном пользователе, можно воспользоваться методом <a target="_blank" href="Documentation/M_ShikiApiLib_ShikiApi_GetUserInfo.md">GetUserInfo</a>.

```C#
UserInfo user_info = user.GetUserInfo();
UserInfo user_info = user.Info; //вернёт последний результат метода выше
```
Помимо того, что метод возвращает инфо сам по себе, он также присваивает его свойству <a target="_blank" href="Documentation/P_ShikiApiLib_ShikiApi_Info.md">Info</a> экземпляра класса <a target="_blank" href="Documentation/T_ShikiApiLib_ShikiApi.md"><strong>ShikiApi</strong></a>.
У экземпляра есть ещё два аналогичный свойства <a target="_blank" href="Documentation/P_ShikiApiLib_ShikiApi_AnimeRates.md">AnimeRates</a> и <a target="_blank" href="Documentation/P_ShikiApiLib_ShikiApi_MangaRates.md">MangaRates</a>, описываемые ниже.
Следует отметить, что при обращении к свойствам в случае отсутствия в них значения (null) они выполнят соответствующий запрос и вернут результат.

Но следует также понимать, что эти методы служат лишь для кэширования последнего результата полученного соответствующим им методом.
В случае, если нужно получить свежие данные с сервера, необходимо обращаться непосредственно к методу, а не к свойству.

#### Получить список тайтлов пользователя
Получить список аниме тайтлов авторизованного пользователя можно следующим способом. Возвращает коллекцию объектов типа <a href="Documentation/T_ShikiApiLib_AnimeRate.md"><strong>AnimeRate</strong></a>.

```C#
List<AnimeRate> animelist = user.GetAnimeRates(); //имеет необязательный аргумент limit, который задаёт кол-во возвращаемых тайтлов (по умолчанию - все)
animelist = user.AnimeRates; //вернёт последний результат метода выше
```
#### Обновить информацию о тайтле в списке пользователя
Для того, чтобы изменить тайтл из списка, необходимо воспользоваться методом <a target="_blank" href="Documentation/M_ShikiApiLib_ShikiApi_UpdateAnimeRate.md">UpdateAnimeRate</a>, который принимает в виде аргументов:
- объект типа *AnimeRate*, который хранит в себе всю инфу пользователя о тайтле;
- статус (перечислимый тип);
- оценка (1 - 10);
- количество просмотренных эпизодов.

Все аргументы, кроме объекта типа <a href="Documentation/T_ShikiApiLib_AnimeRate.md"><strong>AnimeRate</strong></a> необязательные. Возвращает такой же объект типа <a href="Documentation/T_ShikiApiLib_AnimeRate.md"><strong>AnimeRate</strong></a>, но уже с обновлёными после внесения изменений данными.

В случае, если метод используется без единого необязательного аргумента, метод не будет выполнять запрос на сервер, а лишь вернёт тот же самый объект.

```C#
AnimeRate animerate = user.UpdateAnimeRate(title, UserStatus.watching, 7, 12);
```

#### Добавить новый тайтл в список пользователя
Для добавления тайтла в список следует воспользоваться методом <a target="_blank" href="Documentation/M_ShikiApiLib_ShikiApi_CreateAnimeRate.md">CreateAnimeRate</a>, который имеет те же необязательные аргументы, что и метод выше. Обязательный аргумент один - ID тайтла, который намерены добавить. 

```C#
AnimeRate animerate = user.CreateAnimeRate(21); //добавляет в список аниме с ID = 21 (One Piece) с прочими полями по умолчанию (planned, 0, 0)
```

#### Удалить тайтл из списка пользователя
Если необходимо удалить тайтл из списка, то можно воспользоваться методом <a target="_blank" href="Documentation/M_ShikiApiLib_ShikiApi_DeleteRate.md">DeleteRate</a>. Он общий и на аниме, и на мангу. В качестве аргумента принимает поле экземпляра класса <a href="Documentation/T_ShikiApiLib_AnimeRate.md"><strong>AnimeRate</strong></a> - <a href="Documentation/P_ShikiApiLib_TitleRate_UserRateId.md">UserRateId</a>. Возвращает *true* при успешном удалении. 

```C#
bool successDelete = user.DeleteRate(title.UserRateId); //это ID, который присваивается сервером при добавлении тайтла в список.
```

#### Получить подробное инфо о тайтле
Для получения подбробной информации о тайтле есть мутод <a target="_blank" href="Documentation/M_ShikiApiLib_ShikiApi_GetAnimeFullInfo.md">GetAnimeFullInfo</a>, который принимает один аргумент - ID тайтла. Возвращает объект типа <a href="Documentation/T_ShikiApiLib_AnimeFullInfo.md"><strong>AnimeFullInfo</strong></a>. Этот объект также содержит в себе свойство <a href="Documentation/P_ShikiApiLib_TitleFullInfo_UserRate.md">UserRate</a>, которое хранит информацию, которая относится к пользвателю (статус просмотра, оценка, количество просмотренных эпизодов и т.п.).

```C#
AnimeFullInfo anime = GetAnimeFullInfo(21); //получает подробную информацию об аниме с ID = 21 (One Piece)
```
## ShikiApiStatic

Это статический класс, как понятно из названия, и он содержит в себе методы, которые работают ***без*** авторизации на сервере.

Здесь находятся статические аналоги ранее упомянутых методов:

```C#
UserInfo GetUserInfo(int user_id);
List<AnimeRate> GetAnimeRates(int user_id);
AnimeFullInfo GetAnimeFullInfo(int title_id);
```

От нестатических они отличаются тем, что принимают в качестве аргумента id пользователя, инфо или список которого мы хотим получить. 
Последний же метод работает точно также, как и нестатические, разве что его свойство <a href="Documentation/P_ShikiApiLib_TitleFullInfo_UserRate.md">UserRate</a> возвращает *null*

Также класс содержит в себе методы, которые возвращают список аниме студий, манга издательств, жанров и видео (опенинги и эндинги, а не полноценные эпизоды!).

```C#
List<Studio> GetStudios()
Studio GetStudio(int id) // возвращает студию по id

List<Studio> GetPublishers()
Studio GetPublisher(int id) // возвращает издательство по id

List<Genre> GetGenres()
Genre GetGenre(int id) // возвращает жанры по id

List<Video> GetVideos(int title_id) // возвращает видео по id тайтла - работает только для аниме (!)
```

## Поиск аниме/манги. Классы AnimeSearch и MangaSearch

Так как фильтров поиска достаточно много и они довольно гибкие, чтобы сохранить это удобство и широту выбора, пришлось вынести поиск в отдельный класс. Всё описанное ниже будет рассматривать аниме, в качестве примера, но аналогично работает и для манги.

Для того чтобы начать поиск того или иного тайтла, необходимо создать экземпляр класса <a href="Documentation/T_ShikiApiLib_AnimeSearch.md"><strong>AnimeSearch</strong></a> и заполнить соответсвующие свойства-фильтры. 

Слудующие поля это словари типа IDictionary\<T, bool\>, где T - соответсвующий тип перечисления или id жанра/студии/прочего.
Рассмотрим следующий пример:

```C#
AnimeSearch search = new AnimeSearch();
search.order.Add(Order.name, true); // упорядочил поиск по имени тайтла
search.duration.Add(Duration.D, true); // включил в поиск тайтлы продолжительностью до 10
search.duration.Add(Duration.S, true); // и до 30 минут
search.mylist.Add(UserStatus.planned, false); //исключил из списка тайтлы, которые я запланировал
search.mylist.Add(UserStatus.watching, false); //и смотрю
search.GetSearch(user) //метод, который запускает поиск с учётом всех фильтров. Следует выполнять после установления всех фильтров.
                      //принимает в качестве аргумента нашего user'а. Необходимо для учёта фильтра mylist. 
                     //метод можно запускать и без аргументов, но тогда не будет учитываться фильтр наличия в своём листе (mylist).
```

Аналогично вышеуказанным можно добавить фильтры: 
- типа (ТВ, ОВА и пр.) | type
- сезона (весна 2014, например) | season
- возрастного рейтинга | rating
- статуса (вышло, анонсировано и пр.) | status
- жанра | genre
- студии | studio
- оценки (от 8 и выше, к примеру) | score

Также можно:
- включить цензуру при поиске (censored = true), по умолчанию она отключена.
- установить лимит выдачи на страницу, по умолчанию до 50 | limit
  (больше не даёт сервер, чтобы получить остальные результаты, листайте страницы: page = 1, 2, 3, ...).
- установить текст запроса для поиска | text

