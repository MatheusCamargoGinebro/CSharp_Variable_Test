using System;

class Program
{
    static void Main()
    {
        // Variáveis locais:

        // Tipos primitivos:
        byte byteTop = 10; // Entre 0 e 255    // Variável de 8 bits.
        int numeroInteiro = 5;                 // Tipo inteiro com sinal (+ e -).
        float numeroFlutuante = 1.2f;           // Tipo float com sinal (+ e -).
        char letra = 'a';                      // Tipo de caracter.

        // Tipo referência:
        String nome = "Camargo";               // Conjunto de caracteres.

        // Tipagem dinâmica: <3
        var aux = numeroInteiro + numeroFlutuante;   // OBS: uma vez declarado, seu tipo não pode ser mudado.

        // Exibindo valores:
        Console.Write(
            "\nbyte: ----- :" + byteTop + 
            "\nint: ------ :" + numeroInteiro + 
            "\nfloat: ---- :" + numeroFlutuante + 
            "\nchar: ----- :" + letra +
            "\nString: --- :" + nome +
            "\naux: ------ :" + aux +
            "\n"
        );

        Console.WriteLine();
        
    }
}