# Trabajo práctico Nro 3

## Contenido de la actividad

<p>El trabajo práctico consiste en crear un prototipo de videojuego con vista en primera persona con las siguientes funcionalidades.</p>

- Un objeto que representa al jugador, que pueda ser controlado mediante el teclado, utilizando físicas o transform para moverlo.
- Una cámara en primera persona, controlable con el mouse.
- Una mecánica de disparo, ya sea utilizando RayTracing o instanciando proyectiles y detectado colisiones.
- Enemigos que puedan ser destruidos por los disparos
- Una condición de victoria ( llegar a la meta, recolectar x items, destruir todos los enemigos )
- Una condición de derrota ( algo que haga perder el juego: tocar un enemigo, quedarse sin tiempo )
- Una interfaz de usuario que muestre algún valor relativo al estado del juego ( items recolectados, tiempo restante, vida, etc )

<p>Extras:</p>

- Enemigos que persigan al jugador
- UI de la vida del enemigo ( ya sea un numero, o barra de vida)

<p>Entrega del trabajo:</p>

- Crear un repositorio en GitHub, y agregar al docente como colaborador, para darle acceso.
- Subir al repositorio un ejecutable funcionando.
- Subir un video del juego andando, a Youtube, y compartir el link

## Resolucion de la actividad

<p>Entrega del trabajo:</p>

- Link del repositorio: https://github.com/ayelencasamassa/motoresgraficosi/tree/main/Trabajo-Practico-Nro-3
- Link del video del juego: https://youtu.be/Zx3sgL2SEsk

<p>Step by step:</p>

- Se utiliza la version 2020.3.17f1 de Unity.
- Se utiliza el template 3D.
- Se crea una nueva escena llamada "TrabajoPractico3" (se elimina el sample).
- Se crea "Piso":
    - Clic secundario en la escena.
    - GameObject.
    - 3D Object.
    - Plane.
- Se crea "Jugador":
    - Clic secundario en la escena.
    - GameObject.
    - 3D Object.
    - Capsule.
    - Se agrega el componente RigidBody.
- Se arrastra en la jerarquía de objetos a la Main Camera hacia el Jugador. Se mueve cerca del mismo a la altura de sus ojos. 
- Se deshabilita el mesh renderer del Jugador.
- Se crea la carpeta Scripts:
    - Se agrega un script ControlMirarCamara a la Main Camera.
    - Se agrega un script ControlJugador al Jugador.
- Se verifican las teclas WASD para los ejes:
    - ProjectSettings.
    - Input Manager.
    - Verificar las teclas WASD (ejes horizontal y vertical).
- Se crea "Bot":
    - Clic secundario en la escena.
    - GameObject.
    - 3D Object.
    - Cube.
    - Se agrega un script ControlBot.
- Se crea la carpeta Prefabs:
    - Incluir a Bot como Prefab.
- Se bloquear la rotación para que el Jugador no se caiga:
    - Se selecciona el Jugador.
    - RigidBody.
    - Freeze Rotation en el eje “X” y “Z”.
- Se crea "Proyectil":
    - Clic secundario en la escena.
    - GameObject.
    - 3D Object.
    - Cube.
    - Sacle: X=0.05 Y=0.05 Z=0.05.
    - Se le asigna el tag "bala".
    - Se agrega el componente RigidBody.
    - Incluir a Proyectil como Prefab.
- Se crea "Game Manager":
    - Clic secundario en la escena.
    - Create Empty.
    - Se agrega un script ControlJuego.
- Se editan todos los Scripts y se completan las referencias.
