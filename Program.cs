string tamanhoV, serviçoVT, serviçoLG;
int tempo;
decimal Estacionamento = 0, valet = 0, lavagem = 0, total = 0;

Console.WriteLine("--- Estacionamento ---");
Console.Write("Tamanho do veículo (P/G).....: ");
tamanhoV = Console.ReadLine()!.ToUpper();

Console.Write("Tempo de permanência (min)...: ");
tempo = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Serviço de valet (S/N).......: ");
serviçoVT = Console.ReadLine()!.ToUpper();

Console.Write("Serviço de lavagem (S/N).....: ");
serviçoLG = Console.ReadLine()!.ToUpper();



if (tempo > 60)
{
   decimal x = (tempo - 60) / 60;

    if (tamanhoV == "P")
    {
        if (tempo >= 300)
        {
            Estacionamento = 50;
        }
        else
        {
            Estacionamento = x * 10;
        }

        if (serviçoVT == "S")
        {
            valet = Estacionamento / 5;
        }

        if (serviçoLG == "S")
        {
            lavagem = 50;
        }

        total = Estacionamento + valet + lavagem;
    }
    else if (tamanhoV == "G")
    {
        if (tempo >= 300)
        {
            Estacionamento = 80;
        }
        else
        {
            Estacionamento = x * 20 + 20;
        }

        if (serviçoLG == "S")
        {
            valet = Estacionamento / 5;
        }

        if (serviçoLG == "S")
        {
            lavagem = 100;
        }

        total = Estacionamento + valet + lavagem;
    }

    Console.WriteLine(@$"--- Estacionamento ---

Tamanho do veículo (P/G).....: {tamanhoV}
Tempo de permanência (min)...: {tempo}
Serviço de valet (S/N).......: {serviçoVT}
Serviço de lavagem (S/N).....: {serviçoLG}

Estacionamento..:       R$ {Estacionamento:0.00}
Valet...........:        R$ {valet:0.00}
Lavagem.........:        R$ {lavagem:0.00}
--------------------------------
Total...........:        R$ {total:0.00}");
}

else if ((tempo - 60) / 60 <= 0)
{
    Console.WriteLine("Não paga");
}
else
{
    Console.WriteLine("Não aceitar tempo de mais de 12hrs");
}