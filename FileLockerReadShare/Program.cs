namespace FileLockerReadShare
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ファイル名を引数として指定してください。");
                return;
            }

            string filePath = args[0];
            try
            {
                using FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                Console.WriteLine($"{filePath} が読み取り専用で開かれました。");

                // ここでファイルの内容を読み取る処理を追加できます
                // 例: StreamReader を使用してファイル内容を表示する
                // using StreamReader reader = new StreamReader(stream);
                // string content = reader.ReadToEnd();
                // Console.WriteLine(content);

                Console.WriteLine("任意のキーを押すとプログラムを終了します...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"エラー: {ex.Message}");
            }
        }
    }
}
