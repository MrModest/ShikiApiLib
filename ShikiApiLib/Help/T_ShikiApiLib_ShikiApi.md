# ShikiApi - класс
 

Класс авторизованного пользователя. Инициализированный экземпляр класса означает авторизованного пользователя


## Иерархия наследования
<a href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;ShikiApiLib.ShikiApi<br />
**Пространство имён:**&nbsp;<a href="N_ShikiApiLib">ShikiApiLib</a><br />**Сборка:**&nbsp;ShikiApiLib (в ShikiApiLib.dll) Версия: 1.0.0.0 (1.0.0.0)

## Синтаксис

**C#**<br />
``` C#
public class ShikiApi
```

Тип ShikiApi предоставляет следующие члены.


## Конструкторы
&nbsp;<table><tr><th></th><th>Имя</th><th>Описание</th></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi__ctor">ShikiApi(String, String)</a></td><td>
Инициализирует нового пользователя, запрашивая токен и ID пользователя с сайта.</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi__ctor_1">ShikiApi(String, String, Int32)</a></td><td>
Инициализирует нового пользователя, явно задавая значения токена и ID пользователя.</td></tr></table>&nbsp;
<a href="#shikiapi---класс">В начало страницы</a>

## Свойства
&nbsp;<table><tr><th></th><th>Имя</th><th>Описание</th></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ShikiApiLib_ShikiApi_AccessToken">AccessToken</a></td><td>
Токен для работы с API</td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ShikiApiLib_ShikiApi_AnimeRates">AnimeRates</a></td><td>
Хранит последний результат метода <a href="M_ShikiApiLib_ShikiApi_GetAnimeRates">GetAnimeRates(Int32)</a></td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ShikiApiLib_ShikiApi_CurrentUserId">CurrentUserId</a></td><td>
ID пользователя</td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ShikiApiLib_ShikiApi_Info">Info</a></td><td>
Хранит последний результат метода <a href="M_ShikiApiLib_ShikiApi_GetUserInfo">GetUserInfo()</a></td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ShikiApiLib_ShikiApi_MangaRates">MangaRates</a></td><td>
Хранит последний результат метода <a href="M_ShikiApiLib_ShikiApi_GetMangaRates">GetMangaRates(Int32)</a></td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ShikiApiLib_ShikiApi_Nickname">Nickname</a></td><td>
Логин пользователя на сайте</td></tr></table>&nbsp;
<a href="#shikiapi---класс">В начало страницы</a>

## Методы
&nbsp;<table><tr><th></th><th>Имя</th><th>Описание</th></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_CreateAnimeRate">CreateAnimeRate</a></td><td>
Добавляет новое аниме в список пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_CreateMangaRate">CreateMangaRate</a></td><td>
Добавляет новую мангу в список пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_DeleteRate">DeleteRate</a></td><td>
Удаляет выбранный тайтл (аниме или мангу) из списка пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_GetAnimeFullInfo">GetAnimeFullInfo</a></td><td>
Получает подробную информацию об аниме</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_GetAnimeRate">GetAnimeRate</a></td><td>
Получает аниме из списка пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_GetAnimeRates">GetAnimeRates</a></td><td>
Получает список аниме с оценками и прогрессом пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_GetMangaFullInfo">GetMangaFullInfo</a></td><td>
Получает подробную информацию об манге</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_GetMangaRate">GetMangaRate</a></td><td>
Получает мангу из списка пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_GetMangaRates">GetMangaRates</a></td><td>
Получает список манги с оценками и прогрессом пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_GetUserInfo">GetUserInfo</a></td><td>
Получает инфо о пользователе</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_UpdateAnimeRate">UpdateAnimeRate</a></td><td>
Редактирует аниме в списке пользователя</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ShikiApiLib_ShikiApi_UpdateMangaRate">UpdateMangaRate</a></td><td>
Редактирует мангу в списке пользователя</td></tr></table>&nbsp;
<a href="#shikiapi---класс">В начало страницы</a>

## См. также


#### Ссылки
<a href="N_ShikiApiLib">ShikiApiLib - пространство имён</a><br />