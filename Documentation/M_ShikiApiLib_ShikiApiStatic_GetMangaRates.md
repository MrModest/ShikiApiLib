# ShikiApiStatic.GetMangaRates - метод


Получает список манги с оценками и прогрессом пользователя

**Пространство имён:**&nbsp;<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib</a>

## Синтаксис

**C#**<br />
``` C#
public static List<MangaRate> GetMangaRates(
	int user_id,
	int limit = 999999
)
```


#### Параметры
<dl>
	<dt>user_id</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_top">System.Int32</a>
		<br />ID пользователя
	</dd>
	<dt>limit (Optional)</dt>
	<dd>Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_top">System.Int32</a>
		<br />Количество возвращаемой манги (по умолчанию: все)
	</dd>
</dl>

#### Возвращаемое значение
Тип:&nbsp;<a target="_blank" href="http://msdn2.microsoft.com/ru-ru/library/6sh2ey19" target="_top">List</a>(MangaRate)

## См. также


#### Ссылки
<a target="_blank" href="T_ShikiApiLib_ShikiApiStatic.md">ShikiApiStatic - Класс</a>
<br />
<a target="_blank" href="N_ShikiApiLib.md">ShikiApiLib - пространство имён</a>
<br />