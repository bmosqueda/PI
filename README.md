# Proyecto Integrador
## Brainwash

*Cartas:* Tengo la idea de que la información de las cartas la podriamos guardar en un archivo de configuración. Creo que sería mas facil utilizar JSON a comparacion de como lo hicimos el semestre pasado.

Basicamente seria algo asi, guardamos la información en un archivo `CardsConfig.json`, y cada vez que necesitemos los datos de una carta, solo buscamos el objeto.

- Por si no habian oido de los JSON (JavaScript Object Notation) aqui hay un [link](https://geekytheory.com/json-i-que-es-y-para-que-sirve-json/).
- Los archivos que use para probar fueron:
	- Clase [Card.cs](PI/PI/PI/Models/Card.cs).
	- Clase [CardFileController.cs](PI/PI/PI/Controllers/CardFileController.cs).
	- Un framework de JSON para .NET, [Json.NET](https://www.newtonsoft.com/json),
		la [documentacion y turoriales](https://www.newtonsoft.com/json/help/html/DeserializeWithJsonSerializerFromFile.htm).
	- Este es un [ejemplo](PI/PI/PI/JSONTest.json) de cómo quedaria el archivo.
