
using System.Text.Json;

public class Program
{
    static async Task Main(string[] args)
    {
        var tasks = new List<Task<Post>>();
        for (uint i = 4; i <= 13; i++)
        {
            tasks.Add(GetPostByID(i));
        }

        Task.WaitAll(tasks.ToArray());


        using (FileStream fs = new FileStream($"result.txt", FileMode.OpenOrCreate))
        {
            foreach (var task in tasks)
            {
                if (task.IsCompleted && task.Exception == null)
                {
                    byte[] ar = System.Text.Encoding.UTF8.GetBytes(task.Result.ToString());
                    fs.Write(ar, 0, ar.Length);
                }
            }

            
            Console.WriteLine("Текст записан в файл: result.txt");
        }

        using (FileStream fs = File.OpenRead($"result.txt"))
        {
            // преобразуем строку в байты
            byte[] array = new byte[fs.Length];
            // считываем данные
            fs.Read(array, 0, array.Length);
            // декодируем байты в строку
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            Console.WriteLine($"Текст из файла: result.txt \n{textFromFile}");
        }
    }
    private static async Task<Post> GetPostByID(uint postID)
    {
        HttpClient client = new HttpClient();
        var response = await client.GetAsync($"https://jsonplaceholder.typicode.com/posts/{postID}");

        if (response.IsSuccessStatusCode)
        {
            await using var responseStream = await response.Content.ReadAsStreamAsync();
            if (await JsonSerializer.DeserializeAsync<Post>(responseStream, new JsonSerializerOptions(JsonSerializerDefaults.Web)) is Post post)
                return post;
            else
                throw new Exception($"Error content");
        }
        else
        {
            throw new Exception($"Error code: {response.StatusCode}");
        }
    }
}

public class Post
{
    public override string ToString() => $"{UserId}\n{Id}\n{Title}\n{Body}\n\n";

    public uint UserId { get; set; }
    public uint Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}
