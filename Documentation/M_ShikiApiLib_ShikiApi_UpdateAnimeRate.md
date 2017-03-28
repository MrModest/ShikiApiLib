# ShikiApi.UpdateAnimeRate - метод


Редактирует аниме в списке пользователя

**Пространство имён:**&nbsp;<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib</a>

## Синтаксис

**C#**<br />
``` C#
public AnimeRate UpdateAnimeRate(
	AnimeRate title,
	UserStatus status = (UserStatus)99,
	int score = -1,
	int episodes = -1
)
```


#### Параметры
<dl>
	<dt>title</dt>
	<dd>Тип:&nbsp;AnimeRate<br />Аниме требуещее правки</dd>
	<dt>status (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="T_ShikiApiLib_UserStatus.md">ShikiApiLib.UserStatus</a>
		<br />Статус просмотра</dd>
	<dt>score (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_top">System.Int32</a>
		<br />Оценка</dd>
	<dt>episodes (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_top">System.Int32</a>
		<br />Количество просмотренных эпизодов</dd>
</dl>

#### Возвращаемое значение
Тип:&nbsp;AnimeRate

## См. также


#### Ссылки
<a target="_blank" href="T_ShikiApiLib_ShikiApi.md">ShikiApi - Класс</a>
<br />
<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib - пространство имён</a>
<br />