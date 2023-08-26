# API Trivia de Programación 

## Descripción del proyecto
La API Trivia de Programación es una potente interfaz de programación de aplicaciones (API) diseñada para brindar entretenimiento y desafíos relacionados con la programación. Esta solución se basa en una API RESTful construida en el marco de trabajo .NET 6 Core, y tiene como objetivo proporcionar a los usuarios una plataforma divertida para poner a prueba sus conocimientos de programación a través de preguntas y respuestas.

## Arquitectura del proyecto
La API Trivia de Programación sigue una arquitectura organizada en capas para garantizar la eficiencia y la mantenibilidad del sistema.

### Controladores
En la capa de controladores, se encuentran los componentes responsables de manejar las solicitudes HTTP. Estos controladores actúan como puntos de entrada para las peticiones de los clientes y gestionan la interacción con la lógica subyacente.

### Capa de Aplicación
La capa de aplicación contiene la lógica central del proyecto. Aquí se coordinan las interacciones entre los diferentes elementos de la API y se procesan las solicitudes entrantes. Esta capa garantiza que las preguntas de trivia se seleccionen y presenten de manera efectiva.

### Capa de Acceso a Datos
La capa de acceso a datos incluye los Objetos de Transferencia de Datos (DTO) y las validaciones necesarias para asegurar la coherencia de los datos y facilitar la comunicación entre las diversas partes del sistema. Esta capa se encarga de manejar la transformación de los datos entre la aplicación y el almacenamiento.

### Capa de Persistencia
En esta capa, se encuentra el DbContext, las migraciones, las entidades y los mapeos necesarios para la persistencia de los datos en la base de datos. La API Trivia de Programación adopta un enfoque "Code First" para la generación y gestión de la estructura de la base de datos, lo que garantiza una administración eficiente de las preguntas y respuestas de la trivia.

## Características principales
### Preguntas y Respuestas
La API Trivia de Programación ofrece una amplia gama de preguntas desafiantes relacionadas con la programación. Los usuarios pueden disfrutar respondiendo a estas preguntas y poniendo a prueba sus conocimientos técnicos.

### Diseño API RESTful
La API sigue los principios de diseño de una API RESTful, lo que proporciona una interfaz intuitiva y fácil de usar para los clientes. Las rutas y los métodos HTTP están diseñados de manera coherente para una experiencia de usuario cohesiva.

### Validaciones
La API implementa validaciones para garantizar la integridad de los datos y prevenir errores en las solicitudes. Esto contribuye a la confiabilidad y la calidad de la experiencia del usuario.

### Arquitectura en Capas
La arquitectura en capas utilizada en la API Trivia de Programación permite una organización efectiva y una separación clara de responsabilidades. Esto facilita el mantenimiento y la escalabilidad del sistema a medida que crece la cantidad de preguntas y usuarios.

### AutoMapper
La API utiliza AutoMapper para automatizar el mapeo entre objetos DTO y entidades, simplificando la conversión de datos y mejorando la eficiencia del código.

## Repositorio del Frontend

Este repositorio alberga el código correspondiente a la parte del frontend de nuestro proyecto. Aquí encontrarás todos los archivos y recursos necesarios para la interfaz de usuario, así como la documentación pertinente.

🔗[Enlace al Repositorio del Frontend](https://github.com/alelolek/TriviaGame)

## Demo del Código

Hemos preparado un demo en Youtube que muestra el funcionamiento del código en acción. Puedes acceder al demo para explorar sus características y posibilidades.

📺[Enlace al Demo del Código](https://youtu.be/dilPFnFgGs8?si=VyfOD0AywjJUv_31)

## Despliegue del Proyecto

El proyecto ha sido desplegado exitosamente y puedes acceder a él a través del siguiente enlace:

🚀[Enlace al Proyecto Desplegado](https://alelolek.github.io/TriviaGame/)

## Licencia
Este proyecto se distribuye bajo la MIT. Para más información, consulta el archivo [LICENSE](https://github.com/alelolek/ApiTrivia/blob/main/LICENSE.txt).

¡Esperamos que la API Trivia de Programación sea una herramienta emocionante para poner a prueba tus conocimientos de programación y proporcionarte entretenimiento y desafíos! Si tienes alguna pregunta, no dudes en ponerte en contacto con nosotros.