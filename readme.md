## Changelog

**14-03-19, Hash: ffe3d1b63f00b44d6ca9f2451349b737a8e8c93f**

* Reestructuraci�n de servicios
* Test Integraci�n

**05-03-19, Hash: 9a5256597ae31fee7ac3898a06eda4c620ddb308**

* Reestructuraci�n de proyecto
* Agrego test marco repository

**16-09-18, Hash: c8a76a65fde92c50118ed88a32d7fc62047f7a80**

* Dependency injection with Ninject (Final) en Test

**09-09-18, Hash: 483ecb812ddb467125d689e947efb637a0ded8f0**

* Dependency injection with Ninject (Partial)

**01-09-18, Hash: 019d65f6128119fa99be8b7925d680f5f894e742**

* Se implementa Filter para buscar en entidad Varilla y Pedido.

**25-08-18, Hash: 2f3ab964103a73ffee3353c5ed3c497e5d540901**

* Se implementan metodos Add y Update en GenericDAO (Cascade update #46). Mas info en Misc
* Se crea proyecto Assembler con implementaci�n temporal.

**20-08-18, Hash: 045fb9deb127953518e1b15918f5b89bd7e0a142**

* Se crea entidad Comprador.
* Se crea entidad Marco, se desacoplado de la entidad Pedido.
* Refactorizacion de proyectos, se crea carpeta Base, en DAO y Service.
* Se incluye calculo de precio en MarcoService.
* Diagrama DER.
* Test Integraci�n, con modalidad mas usual.

**12-08-18, Hash: 74ec0d0537f3d3781818db4af6827c37475a6013**

* Se implementa nueva arquitectura en DAO y Service (Supertype por capa con genericos) By Blaz77
* Se crea CadresContext By Blaz77
* Se agrega Entidad pedido (Entidad, DAO, Services, Test DAO y Test Service).
* Se agrega proyecto Base, contiene enumerados usados en la aplicaci�n.
* Se agrego carpeta Common en el proyecto de Test con clase Utils para test.
* Se agrega clase EntityConverter en el proyectos entidades, realizar las conversiones entre entidad y DTO provisoriamente.
