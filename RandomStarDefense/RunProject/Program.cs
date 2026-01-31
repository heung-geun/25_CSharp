
using Newtonsoft.Json;
using RunProject;
using System.Threading;


string tolderpath = "C:\\Users\\gudrm\\GitHub\\25_CSharp\\RandomStarDefense\\RunProject";

string fileName = "Jelly.json";

string fullPath = Path.Combine(tolderpath, fileName);


// 파일 읽어오기

string text = File.ReadAllText(fullPath);


    // 파일을 데이터로 해석하기 =>  class 만들기

var jellyDB = JsonConvert.DeserializeObject<List<Jelly>>(text);

//foreach (Jelly i in jellyDB)
//{
//    Console.WriteLine(i);
//}

string p_sgape = "ply";
int p_x = 3;
int p_y = 5;
int score_x = 50;
int score_y = 2;
int currentScore = 0;
int cursor = 5;


while (true)
{
    if (Console.KeyAvailable)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 5);
        Console.WriteLine(" ____                ____            _           _   \r\n|  _ \\ _   _ _ __   |  _ \\ _ __ ___ (_) ___  ___| |_ \r\n| |_) | | | | '_ \\  | |_) | '__/ _ \\| |/ _ \\/ __| __|\r\n|  _ <| |_| | | | | |  __/| | | (_) | |  __/ (__| |_ \r\n|_| \\_\\\\__,_|_| |_| |_|   |_|  \\___// |\\___|\\___|\\__|\r\n                                  |__/               ");
        Console.SetCursorPosition(30, 5);
        Console.WriteLine("게임 시작");
        Console.SetCursorPosition(30, 6);
        Console.WriteLine("게임 종료");
        Console.SetCursorPosition(28, cursor);
        Console.WriteLine("▶");

        var key = Console.ReadKey(true).Key;

        if (key = ConsoleKey.UpArrow)
    }


}


    currentScore = GamePlay(jellyDB, p_sgape, p_x, p_y, score_x, score_y, currentScore);

static int GamePlay(List<Jelly>? jellyDB, string p_sgape, int p_x, int p_y, int score_x, int score_y, int currentScore)
{
    using (var renderer = new ConsoleRenderer(80, 50))

    {

        while (true)
        {

            jellyDB[0].y = 5;
            jellyDB[1].y = 6;
            jellyDB[2].y = 7;

            jellyDB[0].Update();
            jellyDB[1].Update();
            jellyDB[2].Update();

            jellyDB[0].GetScore(p_x, p_y, ref currentScore);
            jellyDB[1].GetScore(p_x, p_y, ref currentScore);
            jellyDB[2].GetScore(p_x, p_y, ref currentScore);

            renderer.Clear();

            renderer.Print(p_x, p_y, p_sgape);
            renderer.Print(score_x, score_y, $"Score: {currentScore}");

            jellyDB[0].Draw(renderer);
            jellyDB[1].Draw(renderer);
            jellyDB[2].Draw(renderer);

            renderer.Flipping();

            Thread.Sleep(33);
        }
    }

    return currentScore;
}