# Geminus

1) Imprimir un tablero de damas donde la "X" representa el color negro y el "_" representa el blanco. El tablero debe tener n x n casillas. Por ejemplo, para n=5 el tablero se vería así:

X_X_X
_X_X_
X_X_X
_X_X_
X_X_X

Tu tablero siempre debe partir con un cuadro negro (una "X") en la esquina superior izquierda y el valor de n puede ir de 1 a 10. En caso de que el valor de n sea diferente, asumir que n es igual a 5.

El código para el tamaño de n ya está ahí, puede editarlo para probar con otros valores y puede hacer clic en el botón de actualización junto a él para volver al valor original que se utiliza para validar su código durante la prueba. Tenga en cuenta que el código debe imprimir los resultados exactamente como se muestra con el fin de que la pregunta sea considerada valida durante la prueba.

Nota: Asumir que esta escribiendo el codigo dentro de una clase, por lo que no debe declarar la clase en si, solo el método public static void main para ejecutar su código.

static int n = 5;
public static void Main() {
    //Your code here
}

2) Se tiene una X en la esquina superior izquierda de un área de 4x4. Se tiene una matriz con 10 elementos. Cada 2 elementos de la matriz corresponden a un movimiento, el primero en el eje horizontal y el segundo en el eje vertical. El número indica las unidades a moverse y el signo la dirección (positivo para derecha o abajo, negativo para izquierda o arriba)

Por ejemplo, para la matriz myArray:=(1,2,-1,1,0,1,2,-1,-1,-2)
La X se moverá una unidad a la derecha y dos hacia abajo, luego una unidad a la izquierda y una abajo y así sucesivamente. El programa a escribir debe imprimir la posición final de la X. Para representar los lugares donde la X no se encuentra utilizar la letra O. Si la instrucción obliga a la X a salir del área de 4x4 la X permanecerá en el borde, sin salir. Para el arreglo presentado el resultado se vería así:

OXOO
OOOO
OOOO
OOOO

Nota: Asumir que esta escribiendo el codigo dentro de una clase, por lo que no debe declarar la clase en si, solo el método public static void main para ejecutar su código.

static int[] myArray = new int[] {1,2,-1,1,0,1,2,-1,-1,-2};
public static void Main() {
    //Your code here
}

3)

dados 3 vagones de tren determinar 
factibilidad de carga en el tren.
la mejor manera de cargar los tres vagones saturando de la mejor manera el espacio de los 3 en forma pareja de modo tal que el peso quede distribuido lo más uniformemente posible. (de esta parte del problema se puede presentar como solución un pseudocódigo)

Nota. Las cajas contienen elementos cuya densidad es similar (una caja más chica es necesariamente más liviana que una más grande, es decir no hay que tener en cuenta el peso más que por el tamaño).
Precargado, 3 vagones de tipo  
Longitud 15.4 mts.
Longitud con acoples 17.1 mts.
Altura 3.0 mts
Capacidad 141 m3
Peso neto sin carga 29 ton
Input:
Cargar cajas ingresadas por teclado hasta que las dimensiones de la caja ingresada sean cero.
Las dimensiones de cada caja son largo, ancho y profundidad.
El sistema debe asegurarse que se cargó correctamente todas las cajas antes de procesar.
