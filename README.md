# Sportradar
Notas:

El proyecto se ha desarrollado en formato consola para ser lo mas simples posible como determina la descrición de la prueba.

Se ha utilizado una estructura muy simples, de apenas una libreria, como determina la descripción.

El programa esta basado en el concepto de parametros de entrada, el usuario deberá introducir parametros para ejecutar las operaciones solicitadas.

Los ID de operacion son:

1 - Añadir un nuevo juego
2 - Finalizar un juego
3 - Actualizar valores del juego
4 - Mostrar sumario de todos los juegos

Para efectuar las operaciones, el usuario deberá introducir parametros como sigue:

Ejemplos de los formatos de entrada:

Formato para criar un nuevo juego (campos: operation id;hometeam;awayteam):

Ex.--> 1;Mexico;Brasil

Formato para finalizar un juego (campos: operation id;id juego): Para seleccionar un juego, use la Id del juego para actualizar o finalizar el juego, esta información aparece en el resumen como por ejemplo: (Id: 0)

Ex.--> 2;0

Formato para actualizar valores de un juego (campos: operation id;idgame;hometeamscore;awayteamscore):

Ex.--> 3;0;0;3

Formato para mostrar el resumen de los juegos (campos: ID de operación):

Ex.--> 4

Formato para mostrar la ayuda (campos: ID de operación):

Ex.--> 5


Para finalizar el juego solo entrar la palabra exit
