# ShikiApi.UpdateMangaRate - метод
 

Редактирует мангу в списке пользователя

**Пространство имён:**&nbsp;<a href="N_ShikiApiLib">ShikiApiLib</a><br />**Сборка:**&nbsp;ShikiApiLib (в ShikiApiLib.dll) Версия: 1.0.0.0 (1.0.0.0)

## Синтаксис

**C#**<br />
``` C#
public MangaRate UpdateMangaRate(
	MangaRate title,
	UserStatus status = UserStatus.planned|UserStatus.watching|UserStatus.completed|UserStatus.on_hold,
	int score = -1,
	int volumes = -1,
	int chapters = -1
)
```


#### Параметры
&nbsp;<dl><dt>title</dt><dd>Тип:&nbsp;MangaRate<br />Манга требующая правки</dd><dt>status (Optional)</dt><dd>Тип:&nbsp;<a href="T_ShikiApiLib_UserStatus">ShikiApiLib.UserStatus</a><br />Статус прочтения</dd><dt>score (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Оценка</dd><dt>volumes (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Количество прочитанных глав</dd><dt>chapters (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Количество прочитанных топов</dd></dl>

#### Возвращаемое значение
Тип:&nbsp;MangaRate

## См. также


#### Ссылки
<a href="T_ShikiApiLib_ShikiApi">ShikiApi - Класс</a><br /><a href="N_ShikiApiLib">ShikiApiLib - пространство имён</a><br />