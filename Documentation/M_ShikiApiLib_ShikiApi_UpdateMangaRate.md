# ShikiApi.UpdateMangaRate - метод


Редактирует мангу в списке пользователя

**Пространство имён:**&nbsp;<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib</a>

## Синтаксис

**C#**<br />
``` C#
public MangaRate UpdateMangaRate(
	MangaRate title,
	UserStatus status = (UserStatus)99,
	int score = -1,
	int volumes = -1,
	int chapters = -1
)
```


#### Параметры
<dl>
	<dt>title</dt>
	<dd>Тип:&nbsp;MangaRate<br />Манга требующая правки</dd>
	<dt>status (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="T_ShikiApiLib_UserStatus.md">ShikiApiLib.UserStatus</a>
		<br />Статус прочтения</dd>
	<dt>score (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_top">System.Int32</a>
		<br />Оценка</dd>
	<dt>volumes (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_top">System.Int32</a>
		<br />Количество прочитанных глав</dd>
	<dt>chapters (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_top">System.Int32</a>
		<br />Количество прочитанных топов</dd>
</dl>

#### Возвращаемое значение
Тип:&nbsp;MangaRate

## См. также


#### Ссылки
<a target="_blank" href="T_ShikiApiLib_ShikiApi.md">ShikiApi - Класс</a>
<br />
<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib - пространство имён</a>
<br />