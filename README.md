<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&color=9df2ea&animation=fadeIn&height=120&section=header"/>

Kata de la Rosa Dorada
============

# Background

Esta kata te pone en el papel de tener que trabajar con el c�digo de otra persona. Se sugiere encarecidamente 
que utilices el desarrollo �test-first� con esta kata.

Hola y bienvenidos al equipo Gilded Rose. Como sabes, somos una peque�a posada con una ubicaci�n privilegiada 
en una ciudad prominente dirigida por una amable posadera llamada Allison. Tambi�n compramos y vendemos s�lo las 
mejores mercanc�as. Desafortunadamente, la calidad de nuestras mercanc�as se degrada constantemente a medida que 
se acercan a su fecha de caducidad. Tenemos un sistema que actualiza nuestro inventario por nosotros. 
Fue desarrollado por un tipo sin sentido llamado Leeroy, que ha pasado a nuevas aventuras. El m�todo UpdateQuality() 
es llamado cada ma�ana por otra parte de nuestro sistema. Su tarea es a�adir la nueva funci�n a nuestro sistema 
para que podamos empezar a vender una nueva categor�a de art�culos. Primero una introducci�n a nuestro sistema:

- Todos los art�culos tienen un valor SellIn que indica el n�mero de d�as que tenemos para vender el art�culo.
- Todos los art�culos tienen un valor de Calidad que indica el valor del art�culo.
- Al final de cada d�a, nuestro sistema reduce ambos valores para cada art�culo.

Bastante sencillo, �verdad? Bueno, aqu� es donde se pone interesante:

- Una vez pasada la fecha de caducidad, la calidad se degrada el doble de r�pido.
- La calidad de un art�culo nunca es negativa.
- El �Brie a�ejo� aumenta su calidad cuanto m�s viejo es.
- La calidad de un producto nunca es superior al 50
- Las �Sulfuras�, al ser un objeto legendario, nunca tienen que venderse ni su calidad disminuye.
- Los �pases entre bastidores�, al igual que el brie a�ejo, aumentan de calidad a medida que se acerca su valor de venta.
	- La calidad aumenta en 2 cuando hay 10 d�as o menos 
	- La calidad aumenta en 3 cuando hay 5 d�as o menos
	- pero la Calidad baja a 0 despu�s del concierto

# Instrucciones

Recientemente hemos fichado a un proveedor de objetos conjurados. Esto requiere una actualizaci�n de nuestro sistema:

- Los art�culos �conjurados� degradan su Calidad el doble de r�pido que los art�culos normales.

Si�ntete libre de hacer cualquier cambio en el m�todo UpdateQuality y a�adir cualquier c�digo nuevo siempre y 
cuando todo siga funcionando correctamente. Sin embargo, **no modifiques la clase Item ni la propiedad Items** 
ya que pertenecen al duende de la esquina que se enfurecer� y te disparar� ya que no cree en la propiedad compartida 
del c�digo (puedes hacer que el m�todo UpdateQuality y la propiedad Items sean est�ticos si quieres, nosotros te cubriremos).

S�lo para aclarar, un �tem nunca puede tener su Calidad incrementada por encima de 50, sin embargo �Sulfuras� 
es un �tem legendario y como tal su Calidad es 80 y nunca se altera.

## Cr�dito Extra

- Las categor�as de los objetos se determinan en funci�n de si contienen una determinada cadena en su nombre 
(por ejemplo, �Brie a�ejo� o �Sulfuras� o �Pases entre bastidores�).
- Cualquier objeto puede ser conjurado, con los efectos resultantes (por ejemplo, �Conjurar pases de backstage�).

# Recursos
- Fuente original de Bobby Johnson (NotMyself) en GitHub](https://github.com/NotMyself/GildedRose)
- C�digo inicial en varios idiomas](https://github.com/emilybache/GildedRose-Refactoring-Kata)

<img src="https://raw.githubusercontent.com/matfantinel/matfantinel/master/waves.svg" width="100%" height="100">