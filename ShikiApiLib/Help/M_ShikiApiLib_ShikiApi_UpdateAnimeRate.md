# ShikiApi.UpdateAnimeRate - метод
 

Редактирует аниме в списке пользователя

**Пространство имён:**&nbsp;<a href="N_ShikiApiLib">ShikiApiLib</a><br />**Сборка:**&nbsp;ShikiApiLib (в ShikiApiLib.dll) Версия: 1.0.0.0 (1.0.0.0)

## Синтаксис

**C#**<br />
``` C#
public AnimeRate UpdateAnimeRate(
	AnimeRate title,
	UserStatus status = UserStatus.planned|UserStatus.watching|UserStatus.completed|UserStatus.on_hold,
	int score = -1,
	int episodes = -1
)
```


#### Параметры
&nbsp;<dl><dt>title</dt><dd>Тип:&nbsp;AnimeRate<br />Аниме требуещее правки</dd><dt>status (Optional)</dt><dd>Тип:&nbsp;<a href="T_ShikiApiLib_UserStatus">ShikiApiLib.UserStatus</a><br />Статус просмотра</dd><dt>score (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Оценка</dd><dt>episodes (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Количество просмотренных эпизодов</dd></dl>

#### Возвращаемое значение
Тип:&nbsp;AnimeRate

## См. также


#### Ссылки
<a href="T_ShikiApiLib_ShikiApi">ShikiApi - Класс</a><br /><a href="N_ShikiApiLib">ShikiApiLib - пространство имён</a><br />