# Ejercicio 4

## ¿String es una tipo por valor o un tipo por referencia?

El string es un tipo de valor por referencia, ya que la variable cuando se crea hace referencia a un espacio de memoria donde se almacena la informacion de la variable creada anteriormente.

## ¿Qué secuencias de escape tiene el tipo string?

Las secuencia de escape del tipo string son las siguientes:

- \": Representa una comilla doble (").
- \': Representa una comilla simple (').
- \\: Representa una barra invertida (\).
- \n: Representa un salto de línea.
- \r: Representa un retorno de carro.
  \t: Representa un tabulador horizontal.
- \b: Representa un retroceso (backspace).
- \f: Representa un avance de página (form feed).
- \v: Representa un tabulador vertical.
- \uxxxx: Representa un carácter Unicode especificado por su valor - hexadecimal de 4 dígitos (por ejemplo, \u0041 representa la letra "A").
- \Uxxxxxxxx: Representa un carácter Unicode especificado por su valor - hexadecimal de 8 dígitos (requiere la notación de mayúsculas, por ejemplo, - \U0001F600 representa el emoji de una cara sonriente).

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

### Cuando utilizas el carácter @ antes de una cadena de texto en C#, se conoce como verbatim string literal (literal de cadena literal) y tiene algunos efectos especiales en la interpretación de la cadena.

- Escape de secuencias de caracteres: Al utilizar @ antes de una cadena de texto, las secuencias de escape como \n, \t, etc. ya no tienen un significado especial y se interpretan literalmente como caracteres normales. Esto significa que no es necesario utilizar dobles barras invertidas para representar una barra invertida literal (\\), por ejemplo.

- Inclusión literal de caracteres de nueva línea: Al utilizar @ antes de una cadena de texto, puedes incluir caracteres de nueva línea sin utilizar secuencias de escape como \n. Esto es especialmente útil cuando deseas mantener el formato de una cadena de texto, como en la escritura de un bloque de texto con varias líneas.
