# ShikiApi - класс

Класс авторизованного пользователя. 
Инициализированный экземпляр класса означает авторизованного пользователя

## Иерархия наследования
<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_top">System.Object</a>
<br />&nbsp;&nbsp;ShikiApiLib.ShikiApi<br />
**Пространство имён:**&nbsp;<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib</a>

## Синтаксис

**C#**<br />
``` C#
public class ShikiApi
```

Тип ShikiApi предоставляет следующие члены.


## Конструкторы

<table>
	<tr>
		<th/>
		<th>Имя</th>
		<th>Описание</th>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi__ctor.md">ShikiApi(String, String)</a>
		</td>
		<td>Инициализирует нового пользователя, запрашивая токен и ID пользователя с сайта.</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi__ctor_1.md">ShikiApi(String, String, Int32)</a>
		</td>
		<td>Инициализирует нового пользователя, явно задавая значения токена и ID пользователя.</td>
	</tr>
</table>
<a href="#shikiapi---класс">В начало страницы</a>

## Свойства

<table>
	<tr>
		<th/>
		<th>Имя</th>
		<th>Описание</th>
	</tr>
	<tr>
		<td><img src="media/pubproperty.gif" /></td>
		<td>
			<a target="_blank" href="P_ShikiApiLib_ShikiApi_AccessToken.md">AccessToken</a>
		</td>
		<td>Токен для работы с API</td>
	</tr>
	<tr>
		<td><img src="media/pubproperty.gif" /></td>
		<td>
			<a target="_blank" href="P_ShikiApiLib_ShikiApi_AnimeRates.md">AnimeRates</a>
		</td>
		<td>Хранит последний результат метода <a target="_blank" href="M_ShikiApiLib_ShikiApi_GetAnimeRates.md">GetAnimeRates(Int32)</a>
		</td>
	</tr>
	<tr>
		<td><img src="media/pubproperty.gif" /></td>
		<td>
			<a target="_blank" href="P_ShikiApiLib_ShikiApi_CurrentUserId.md">CurrentUserId</a>
		</td>
		<td>ID пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubproperty.gif" /></td>
		<td>
			<a target="_blank" href="P_ShikiApiLib_ShikiApi_Info.md">Info</a>
		</td>
		<td>Хранит последний результат метода <a target="_blank" href="M_ShikiApiLib_ShikiApi_GetUserInfo.md">GetUserInfo()</a>
		</td>
	</tr>
	<tr>
		<td><img src="media/pubproperty.gif" /></td>
		<td>
			<a target="_blank" href="P_ShikiApiLib_ShikiApi_MangaRates.md">MangaRates</a>
		</td>
		<td>Хранит последний результат метода <a target="_blank" href="M_ShikiApiLib_ShikiApi_GetMangaRates.md">GetMangaRates(Int32)</a>
		</td>
	</tr>
	<tr>
		<td><img src="media/pubproperty.gif" /></td>
		<td>
			<a target="_blank" href="P_ShikiApiLib_ShikiApi_Nickname.md">Nickname</a>
		</td>
		<td>Логин пользователя на сайте</td>
	</tr>
</table>
<a href="#shikiapi---класс">В начало страницы</a>

## Методы

<table>
	<tr>
		<th/>
		<th>Имя</th>
		<th>Описание</th>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_CreateAnimeRate.md">CreateAnimeRate</a>
		</td>
		<td>Добавляет новое аниме в список пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_CreateMangaRate.md">CreateMangaRate</a>
		</td>
		<td>Добавляет новую мангу в список пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_DeleteRate.md">DeleteRate</a>
		</td>
		<td>Удаляет выбранный тайтл (аниме или мангу) из списка пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_GetAnimeFullInfo.md">GetAnimeFullInfo</a>
		</td>
		<td>Получает подробную информацию об аниме</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_GetAnimeRate.md">GetAnimeRate</a>
		</td>
		<td>Получает аниме из списка пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_GetAnimeRates.md">GetAnimeRates</a>
		</td>
		<td>Получает список аниме с оценками и прогрессом пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_GetMangaFullInfo.md">GetMangaFullInfo</a>
		</td>
		<td>Получает подробную информацию об манге</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_GetMangaRate.md">GetMangaRate</a>
		</td>
		<td>Получает мангу из списка пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_GetMangaRates.md">GetMangaRates</a>
		</td>
		<td>Получает список манги с оценками и прогрессом пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_GetUserInfo.md">GetUserInfo</a>
		</td>
		<td>Получает инфо о пользователе</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_UpdateAnimeRate.md">UpdateAnimeRate</a>
		</td>
		<td>Редактирует аниме в списке пользователя</td>
	</tr>
	<tr>
		<td><img src="media/pubmethod.gif" /></td>
		<td>
			<a target="_blank" href="M_ShikiApiLib_ShikiApi_UpdateMangaRate.md">UpdateMangaRate</a>
		</td>
		<td>Редактирует мангу в списке пользователя</td>
	</tr>
</table>
<a href="#shikiapi---класс">В начало страницы</a>

## См. также


#### Ссылки
<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib - пространство имён</a>
<br />