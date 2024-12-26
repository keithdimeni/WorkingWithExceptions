namespace WorkingWithExceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var vetor = new int[3];

        try
        {
            //for (int index = 0; index < 5; index++)
            //{
            //    Console.WriteLine(vetor[index]);
            //}

            Cadastrar("");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("falha ao cadastrar texto, por favor, informe um texto válido");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrei o índice na lista");
        }
        catch (Exception ex) //se a excessão não for tratada, não a necessidade de capturar a excessão
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado!");
        }
        finally
        {
            Console.WriteLine("Finalizando o programa");
        }
    }

    private static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            throw new ArgumentNullException(nameof(texto), "O texto não pode ser nulo ou vazio");
    }
}