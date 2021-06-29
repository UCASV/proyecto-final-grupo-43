# Aspectos técnicos 

##  Software
El software que utilizamos para desarrollar nuestro proyecto fue **Microsoft Visual Studio**, es un IDE que se encuentra disponible para Windows y macOS, cuenta con una variedad de lenguajes compatibles como C++, C#, Visual Basic .NET, Java, Python, Ruby y PHP, también nos  brindan entornos de desarrollo web como ASP.NET, Django, etc.

Se utilizo **.NET** para poder realizar el programa, en la versión 5.0 que es su versión más actualizada, en formato  de **Windows Forms Apps.**


## Sistema Operativo
El sistema operativo que utilizamos todos los integrantes para el desarrollo del proyecto fue Windows en su versión 10.

## Paquetes Externos 
Los paquetes externos que se implementaron en el programa son los los siguientes 5 **nugets** en sus respectivas versiones recientes estables:

-Microsoft.EntityFrameworkCore.SqlServer 5.0.7

-Microsoft.EntityFrameworkCore 5.0.7

-Microsoft.EntityFreameworkCore.Design 5.0.7

-iTextSharp.LGPLv2.Core

-itext7

# Instalación 

## Visual Studio
Gracias a Microsoft pudimos utilizar **Visual Studio 2019**, tiene su propia página web en el cual se encuentra su apartado de descarga, al ingresar al link <https://visualstudio.microsoft.com/es/downloads/> encontraremos tres opciones para descargar el instalador que son Comunity, Profetional y Enterprise.

 En nuestro caso instalamos la versión Comunity ya que es la unica versión con licencia gratuita, en cambio los demás tienen una prueba gratuita pero al pasar el tiempo de prueba, se le solicitara realizar un pago para conseguir la licencia y poder seguir ocupando esa versión de Visual Studio.
 
  Dentro del instalador el usuario podrá configurar los lenguajes y las herramientas que desea instalar para acceder a ellas.

  Para poder usar nuestro programa será necesario que al momento de la insatalación de Visual Studio, se agregue la "carga de trabajo" o **Workload** llamado .NET desktop developement que se encuentra en el apartado de escritorio y mobiles.



## SQL Server

Realizamos nuestra base de datos para el desarrollo del proyecto en **SQL Server Management Studio (SSMS)**.

Para instalarlo debemos entrar al siguiente link: <https://www.microsoft.com/es-es/sql-server/sql-server-downloads>.

Se nos mostraran dos opciones de descarga, la opción de descargar "versión de Desarrollador" y la "versión Express", la diferencia entre estas dos, a gran escala es que la de Desarrollador nos permite hacer programas de manera más grande y completas que la Express, pero las dos versiones serán completamente viables para poder visualizar y usar la base de datos creada para usar en el proyecto.

En cualquiera de las dos opciones que se eliga, se descargara un instalador que se encargara de descargar e instalar todo lo necesario para obtener la versión de SQL Server elegida.

Abrimos el instalador y se nos darán 3 opciones de instalación, la básica, perzonalizada y la descarga de medios, se recomienda elegir la opción "Básica".

Al finalizar la instalación, se nos mostrara una pestaña con opciones, ya que hasta el momento solo hemos instalado un **Motor de bases de datos**, en las opciones que se nos presentan en esta pestaña está "Instalar SSMS", que es un gestor grafico para el motor de bases de datos que utilizaremos, procedemos a instalarlo y ahora si, estamos listos para poder usar **SQL Server.**

## Base de datos existente

Para utilizar el programa creado, se necesita usar la base de datos creada para este proyecto en especifico, utilizamos una cadena de conexión al IDE de Visual Studio para vincularlo, ya que contaba con las tablas y valores hechos para solo desarrollarlo por código.





