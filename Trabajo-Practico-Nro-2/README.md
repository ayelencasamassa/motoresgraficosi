# Trabajo práctico Nro 2

## Contenido de la actividad

<p>El trabajo práctico consiste en crear un prototipo de videojuego con vista en tercera persona con las siguientes funcionalidades:</p>

- Un objeto que representa al jugador, que pueda ser controlado mediante el teclado, utilizando físicas (addForce) para moverlo.
- Una cámara que siga al jugador en su desplazamiento.
- Una condición de victoria (llegar a la meta, recolectar x items, destruir todos los enemigos)
- Una condición de derrota (algo que haga perder el juego: caer al vacío, tocar un enemigo, quedarse sin tiempo)
- Una interfaz de usuario que muestre algún valor relativo al estado del juego (items recolectados, tiempo restante, vida, etc)

<p>Entrega del trabajo:</p>

- Crear un repositorio en GitHub, y agregar al docente como colaborador, para darle acceso.
- Subir al repositorio un ejecutable funcionando.
- Subir un video del juego andando, a Youtube, y compartir el link

## Resolucion de la actividad

<p>Entrega del trabajo:</p>

- Link del repositorio: https://github.com/ayelencasamassa/motoresgraficosi/tree/main/Trabajo-Practico-Nro-2
- Link del video del juego:

<p>Step by step:</p>

- Se utiliza la version 2020.3.17f1 de Unity.
- Se utiliza el template 3D.
- Se crea una nueva escena llamada "TrabajoPractico2" (se elimina el sample).
- Se crea "Piso":
    - Clic secundario en la escena
    - GameObject
    - 3D Object
    - Plane
    - Se modifica la propiedad Scale en el inspector: X=10 Y=10 Z=10
- Se modifica el Transform de la camara de la siguiente manera:
    - Position: X=50 Y=10 Z=-50
    - Rotation: X=0 Y=-45 Z=0
    - Sacle: X=1 Y=1 Z=1
- Se crea "Jugador":
    - Clic secundario en la escena
    - GameObject
    - 3D Object
    - Shpere
    - Se modifica la propiedad Scale en el inspector: X=10 Y=10 Z=10
    - Se modifica la propiedad Position en el inspector: X=0 Y=10 Z=0
    - Se agrega el componente RigidBody
- Se crea una carpeta "Materials" y se colocan los materiales que se utilizan en la escena.
- Se crea un objeto vacio llamado "Paredes":
    - Clic secundario en la escena
    - Create Empty
    - Se resetea el objeto.
- Se crean cuatro paredes y se agrupan dentro de "Paredes".
    - Pared1:
        - Position: X=0 Y=10 Z=-50
        - Rotation: X=90 Y=0 Z=0
        - Sacle: X=10 Y=10 Z=2
    - Pared2:
        - Position: X=-50 Y=10 Z=0
        - Rotation: X=90 Y=90 Z=0
        - Sacle: X=10 Y=10 Z=2
    - Pared3:
        - Position: X=0 Y=10 Z=50
        - Rotation: X=90 Y=180 Z=0
        - Sacle: X=10 Y=10 Z=2
    - Pared4:
        - Position: X=50 Y=10 Z=0
        - Rotation: X=90 Y=0 Z=90
        - Sacle: X=10 Y=10 Z=2
- se edita la Directional Light
    - Position: X=30 Y=40 Z=-60
    - Rotation: X=50 Y=-30 Z=0
    - Sacle: X=1 Y=1 Z=1
    - Shadow Type = No Shadows
- Se crea la carpeta “Scripts”.
- Se crea el archivo ControlJugador.cs y se asocia a "Jugador".
    - Se setea "Rapidez" en el inspector = 10.
- Se crea el archivo ControlCamara.cs y se asocia a "Main Camera".
    - Se setea el jugador en el inspector.
- Se crea "LingoteDeOro":
    - Clic secundario en la escena
    - GameObject
    - 3D Object
    - Cube
    - Se modifica la propiedad Scale en el inspector: X=2 Y=2 Z=2
    - Se modifica la propiedad Rotation en el inspector: X=45 Y=45 Z=45
- Se crea la carpeta “Prefabs”.
- Se arrastra el LingoteDeOro a la carpeta Prefabs.
    - Se ingresa al modo prefab.
    - Se asocia un nuevo script llamado "Rotador".
    - Se crea una tag “coleccionable” y se asigna al prefab LingoteDeOro.
    - Se agrega un componente RigidBody.
    - Se configura "is Trigger" e "is Kinematic" en true. 
- Se agregan varios LingoteDeOro en el escenario.
    - "LingoteDeOro1": Position: X=40 Y=12 Z=2
    - "LingoteDeOro2": Position: X=2 Y=12 Z=40
    - "LingoteDeOro3": Position: X=-40 Y=12 Z=-2
    - "LingoteDeOro4": Position: X=-2 Y=12 Z=-40
- Se agregan dos objetos tipo Text:
    - Clic secundario en la escena
    - UI
    - Text
        - "TextoObjetosRecolectados"
        - "TextoGanaste"
- Se posicionan los Text en el canvas y se edita el contenido.
- Se modifica el archivo ControlJugador.cs.
    - Se setean los textos en el inspector.
    - Se setean "Capa Piso" y "Magnitud Salto".
- Se crea una nueva Layer "Jugador" y se modifica el layer del objeto Jugador.
- Se crea un Physic Material "Jugador" y se asocia al objeto "Jugador".
    - Se aumentar el valor de bounciness (rebote) a 1 en el material físico. 
- Se mejoran las texturas.


