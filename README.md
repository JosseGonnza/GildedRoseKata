<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&color=9df2ea&animation=fadeIn&height=120&section=header"/>

GildedRose || Refactoring Kata
============

# Background

Esta kata te pone en el papel de tener que trabajar con el código de otra persona. Se sugiere encarecidamente que utilices el desarrollo «test-first» con esta kata.

Hola y bienvenidos al equipo Gilded Rose. Como sabes, somos una pequeña posada con una ubicación privilegiada en una ciudad prominente dirigida por una amable posadera llamada Allison. También compramos y vendemos sólo las mejores mercancías. Desafortunadamente, la calidad de nuestras mercancías se degrada constantemente a medida que se acercan a su fecha de caducidad. Tenemos un sistema que actualiza nuestro inventario por nosotros. 
Fue desarrollado por un tipo sin sentido llamado Leeroy, que ha pasado a nuevas aventuras. El método UpdateQuality() es llamado cada mañana por otra parte de nuestro sistema. Su tarea es añadir la nueva función a nuestro sistema para que podamos empezar a vender una nueva categoría de artículos. Primero una introducción a nuestro sistema:

- Todos los artículos tienen un valor SellIn que indica el número de días que tenemos para vender el artículo.
- Todos los artículos tienen un valor de Calidad que indica el valor del artículo.
- Al final de cada día, nuestro sistema reduce ambos valores para cada artículo.

Bastante sencillo, ¿verdad? Bueno, aquí es donde se pone interesante:

- Una vez pasada la fecha de caducidad, la calidad se degrada el doble de rápido.
- La calidad de un artículo nunca es negativa.
- El «Brie añejo» aumenta su calidad cuanto más viejo es.
- La calidad de un producto nunca es superior al 50
- Las «Sulfuras», al ser un objeto legendario, nunca tienen que venderse ni su calidad disminuye.
- Los «pases entre bastidores», al igual que el brie añejo, aumentan de calidad a medida que se acerca su valor de venta.
	- La calidad aumenta en 2 cuando hay 10 días o menos 
	- La calidad aumenta en 3 cuando hay 5 días o menos
	- Pero la Calidad baja a 0 después del concierto

# Instrucciones

Recientemente hemos fichado a un proveedor de objetos conjurados. Esto requiere una actualización de nuestro sistema:

- Los artículos «conjurados» degradan su Calidad el doble de rápido que los artículos normales.

Siéntete libre de hacer cualquier cambio en el método UpdateQuality y añadir cualquier código nuevo siempre y cuando todo siga funcionando correctamente. Sin embargo, **no modifiques la clase Item ni la propiedad Items** ya que pertenecen al duende de la esquina que se enfurecerá y te disparará ya que no cree en la propiedad compartida del código (puedes hacer que el método UpdateQuality y la propiedad Items sean estáticos si quieres, nosotros te cubriremos).

Sólo para aclarar, un ítem nunca puede tener su Calidad incrementada por encima de 50, sin embargo «Sulfuras» es un ítem legendario y como tal su Calidad es 80 y nunca se altera.

## Crédito Extra

- Las categorías de los objetos se determinan en función de si contienen una determinada cadena en su nombre (por ejemplo, «Brie añejo» o «Sulfuras» o «Pases entre bastidores»). 
- Cualquier objeto puede ser conjurado, con los efectos resultantes (por ejemplo, «Conjurar pases de backstage»).

# Recursos
- Fuente original de Bobby Johnson (NotMyself) en GitHub](https://github.com/NotMyself/GildedRose)
- Código inicial en varios idiomas](https://github.com/emilybache/GildedRose-Refactoring-Kata)

<img src="https://raw.githubusercontent.com/matfantinel/matfantinel/master/waves.svg" width="100%" height="100">