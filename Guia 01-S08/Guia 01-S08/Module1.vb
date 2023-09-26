Module Module1

    Sub Main()
        'Ejercicio1()
        'Ejercicio2()
        'Ejercicio3()
        Ejercicio4()


    End Sub


    Sub Ejercicio1()

        Dim distancia As Double = 42.195
        Dim horas As Integer
        Dim minutos As Integer
        Dim tiempoTotal As Double
        Dim velocidadKmH As Double
        Dim velocidadKmMin As Double
        Dim velocidadKmS As Double
        Dim velocidadMm As Double
        Dim velocidadMs As Double

        Console.WriteLine("Introduce las horas:")
        horas = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Introduce los minutos:")
        minutos = Convert.ToInt32(Console.ReadLine())

        tiempoTotal = horas * 60 + minutos

        velocidadKmH = distancia / tiempoTotal

        velocidadKmMin = distancia / tiempoTotal * 60

        velocidadKmS = distancia / tiempoTotal * 3600

        velocidadMm = distancia * 60 / tiempoTotal

        velocidadMs = distancia / tiempoTotal * 3600

        Dim Codigo = "DD2226012022"
        Dim Carrera = "Tecnico en Computacion"

        Console.WriteLine("Velocidad media en Km/h es de: " & velocidadKmH)
        Console.WriteLine("Velocidad media en Km/min es de: " & velocidadKmMin)
        Console.WriteLine("Velocidad media en Km/s es de: " & velocidadKmS)
        Console.WriteLine("Velocidad media en m/min es de: " & velocidadMm)
        Console.WriteLine("Velocidad media en m/s es de: " & velocidadMs)

        'En el primer ejercico se me ocurrio concatenar mis datos lo deje asi por la experiencia pero
        'me guso y me gusta mas de la otra manera de solo imprimir mis datos por separado

        Console.WriteLine("Ejercico Desarrolado por Bryan Alexis Duran Duran")
        Console.WriteLine("Codigo: " & Codigo & " carrera: " & Carrera)

    End Sub


    Sub Ejercicio2()

        Dim infraccionesMes As Double
        Dim infraccionesDiariasMatutino As Double
        Dim infraccionesDiariasTarde As Double
        Dim infraccionesDiariasNoche As Double

        Console.WriteLine("Introduce el promedio mensual de infracciones:")
        infraccionesMes = Convert.ToDouble(Console.ReadLine())


        infraccionesDiariasMatutino = infraccionesMes * 0.2

        infraccionesDiariasTarde = infraccionesMes * 0.35

        infraccionesDiariasNoche = infraccionesMes * 0.45

        Console.WriteLine("Promedio diario matutino de infracciones: " & infraccionesDiariasMatutino)
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & infraccionesDiariasTarde)
        Console.WriteLine("Promedio diario nocturno de infracciones: " & infraccionesDiariasNoche)


        Console.WriteLine("Ejercicio Desarrollado por Bryan Alexis Duran Duran")
        Console.WriteLine("Codigo: DD2226012022")
        Console.WriteLine("Carrera: Tecnico en Computacion")

    End Sub


    Sub Ejercicio3()

        Dim num1 As Integer
        Dim num2 As Integer

        Console.WriteLine("Introduzca el primero numero: ")
        num1 = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Introduzca el segundo numero: ")
        num2 = Convert.ToInt32(Console.ReadLine())

        If num1 Mod num2 = 0 Then
            Console.WriteLine("El número " & num1 & " es divisor de " & num2)
        Else
            Console.WriteLine("El número " & num1 & " no es divisor de " & num2)
        End If


        Console.WriteLine("Ejercicio Desarrollado por Bryan Alexis Duran Duran")
        Console.WriteLine("Codigo: DD2226012022")
        Console.WriteLine("Carrera: Tecnico en Computacion")

    End Sub


    Sub Ejercicio4()

        Console.WriteLine("Introduce 3 numeros diferentes")

        Console.WriteLine("Ingrese el primer número:")
        Dim num1 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo número:")
        Dim num2 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese el tercer número:")
        Dim num3 As Integer = Integer.Parse(Console.ReadLine())

        If num1 = num2 Or num1 = num3 Or num2 = num3 Then
            Console.WriteLine("Los tres números introducidos no son diferentes.")
            Exit Sub

        End If

        Dim mayor As Integer
        Dim medio As Integer
        Dim menor As Integer

        If num1 > num2 And num1 > num3 Then
            mayor = num1
            If num2 > num3 Then
                medio = num2
                menor = num3
            Else
                medio = num3
                menor = num2
            End If
        ElseIf num2 > num1 And num2 > num3 Then
            mayor = num2
            If num1 > num3 Then
                medio = num1
                menor = num3
            Else
                medio = num3
                menor = num1
            End If
        Else
            mayor = num3
            If num1 > num2 Then
                medio = num1
                menor = num2
            Else
                medio = num2
                menor = num1
            End If
        End If

        Console.WriteLine("El numero mayor es: " & mayor)
        Console.WriteLine("El numero medio es: " & medio)
        Console.WriteLine("El numero menor es: " & menor)


        Console.WriteLine("Ejercicio Desarrollado por Bryan Alexis Duran Duran")
        Console.WriteLine("Codigo: DD2226012022")
        Console.WriteLine("Carrera: Tecnico en Computacion")

    End Sub


End Module
