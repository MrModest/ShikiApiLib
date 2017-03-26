# ShikiApiStatic.GetAnimeRates - метод
 

Получает список аниме с оценками и прогрессом пользователя

**Пространство имён:**&nbsp;<a href="N_ShikiApiLib">ShikiApiLib</a><br />**Сборка:**&nbsp;ShikiApiLib (в ShikiApiLib.dll) Версия: 1.0.0.0 (1.0.0.0)

## Синтаксис

**C#**<br />
``` C#
public static List<AnimeRate> GetAnimeRates(
	int user_id,
	int limit = 999999
)
```


#### Параметры
&nbsp;<dl><dt>user_id</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />ID пользователя</dd><dt>limit (Optional)</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />Количество возвращаемых аниме (по умолчанию: все)</dd></dl>

#### Возвращаемое значение
Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/6sh2ey19" target="_blank">List</a>(AnimeRate)

## См. также


#### Ссылки
<a href="T_ShikiApiLib_ShikiApiStatic">ShikiApiStatic - Класс</a><br /><a href="N_ShikiApiLib">ShikiApiLib - пространство имён</a><br />