# ShikiApi.CreateAnimeRate - метод
 

Добавляет новое аниме в список пользователя

**Пространство имён:**&nbsp;<a href="N_ShikiApiLib">ShikiApiLib</a><br />**Сборка:**&nbsp;ShikiApiLib (в ShikiApiLib.dll) Версия: 1.0.0.0 (1.0.0.0)

## Синтаксис

**C#**<br />
``` C#
public AnimeRate CreateAnimeRate(
	int title_id,
	UserStatus status = UserStatus.planned|UserStatus.watching|UserStatus.completed|UserStatus.on_hold,
	int score = 0,
	int episodes = 0
)
```


#### Параметры
&nbsp;<dl><dt>title_id</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />ID аниме</dd><dt>status (Optional)</dt><dd>Тип:&nbsp;<a href="T_ShikiApiLib_UserStatus">ShikiApiLib.UserStatus</a><br />Статус просмотра</dd><dt>score (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Оценка</dd><dt>episodes (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Количество просмотренных эпизодов</dd></dl>

#### Возвращаемое значение
Тип:&nbsp;AnimeRate

## См. также


#### Ссылки
<a href="T_ShikiApiLib_ShikiApi">ShikiApi - Класс</a><br /><a href="N_ShikiApiLib">ShikiApiLib - пространство имён</a><br />