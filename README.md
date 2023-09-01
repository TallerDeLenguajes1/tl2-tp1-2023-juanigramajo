# tl2-tp1-2023-juanigramajo

---
# Ejercicio 2 a.
### ¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación?
- La relación pedido-cliente es una relación de composición ya que menciona que si se elimina el pedido se debe eliminar el cliente
- La relación pedido-cadete es una relación de agregación ya que si elimino el cadete el pedido puede ser asignado a otro cadete
- La relación cadete-cadeteria es una relación de agregación ya que si elimino la cadeteria no es necesario eliminar el cadete (porque el cadete es una persona, puede trabajar en otro lado, por eso no veo necesario eliminar el objeto).

### ¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete?
Cadetería
- tomarPedido()
- añadirCadete()
- eliminarCadete()
- modificarCadete()
- reasignarCadete()

Cadete
- asignarPedido()
- listarPedidos()
- finalizarPedido()


### Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos, propiedades y métodos deberían ser públicos y cuáles privados.
De las 4 clases pondría todos los atributos privados y todos los metodos públicos.

### ¿Cómo diseñaría los constructores de cada una de las clases?

Al construir el pedido, solicitaría los datos del cliente para crearlo desde esa clase. Las demás con sus respectivos constructores que completen la información solicitada. Para cadete tendría en cuenta que no es necesario que tenga un pedido asignado para ser creado, que se pueda crear sin darle valores al atributo _listadoPedidos_.

