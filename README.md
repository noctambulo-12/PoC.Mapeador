# PoC.Mapeador
Mapear objetos es una actividad común que realizamos los programadores, para realizar esta tarea de forma fácil existen muchas librerías siendo la más popular la archiconocida **AutoMapper**.
</p>

**Mapster** es una de las mejores librerías *(del momento)* de código abierto para realizar el mapeo de objetos simples y compuestos en .NET. 
Sobresaliendo principalmente por su rendimiento *(alta velocidad y poco consumo de memoria)* además de su facilidad de uso el cual permite crear código más limpio y mantenible.

Para usar **Mapster** no se necesita crear ninguna configuración previa *(Funciona mediante métodos de extensión)*

Mapear un objeto  es tan sencillo como escribir esta línea:

```c#
var destinyObject = sourceObject.Adapt<Destination>();
```
</p>
Además es posible adicionar **ExpressionDebugger** para poder debuggear dentro del mapeo sin perder eficiencia, y resolviendo una de las mayores desventajas de usar librerías de mapeo automático.
</p>
</br>

<img src="https://raw.githubusercontent.com/noctambulo-12/PoC.Mapeador/main/Picture/PoC.Mapeador.png"> 

Fuente: [Nick Chapsas](https://www.youtube.com/watch?v=UIslFVEHkzA")


### Documentación
* https://github.com/MapsterMapper/Mapster

