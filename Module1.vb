Module Module1

    Sub Main()
        'determinar el monto de un cheque 
        'tendrá que ir por equis número de días a la ciudad de Monterrey
        'hotel, comida y 100.00 pesos diarios 
        'desglosado para cada concepto

        Dim empleado As String
        Dim dias As Int32
        Dim diashospedaje As Int32
        Dim valorhospedaje As Double
        Dim hotel As String
        Dim totalhotel As Int32
        Dim totalcomida As Double
        Dim valorcomida As Double
        Dim total As Double
        Dim otrosbiaticos As Int32

        Console.WriteLine("Ingrese Nombre del Empleado: ")
        empleado = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de dias en Monte Rey:")
        dias = Console.ReadLine()
        Console.WriteLine("ingrese nombre del hotel")
        hotel = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad de dias de hospedaje: ")
        diashospedaje = Console.ReadLine()
        Console.WriteLine("Ingrese Valor de hospedaje por dia: ")
        valorHospedaje = Console.ReadLine()
        Console.WriteLine("ingrese valor de biatico para comida asignado por dia:")
        valorcomida = Console.ReadLine

        totalcomida = dias * valorcomida
        totalhotel = diashospedaje * valorhospedaje
        otrosbiaticos = dias * 100
        total = totalcomida + otrosbiaticos + totalhotel
        Console.WriteLine()

        Console.WriteLine("cheque a Nombre de: " & empleado)
        Console.WriteLine("Con " & diashospedaje & " Noches de hospedaje en el hotel: " & hotel & ", con un total de: $" & totalhotel)
        Console.WriteLine("biaticos de comida con un valor de: $" & valorcomida & " correspondiente a: " & dias & " Dias")
        Console.WriteLine("Otros biaticos: $100 por dia con valor total de: $ " & otrosbiaticos)
        Console.WriteLine("Corresponde confecionar cheque con un total de: $" & total)

        Console.Read()
    End Sub
End Module