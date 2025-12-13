using LOL_Chrarcter;
using Newtonsoft.Json;

// (1) 폴더에서 파일 경로 가져오기

// 솔루션 탐색기에서 json 파일이 들어있는 폴더의 경로 가져오기(우클릭 후 파일탐색기 오픈)
string tolderpath = "C:\\Users\\gudrm\\GitHub\\25_CSharp\\LOL_Chrarcter\\LOL_Chrarcter";

// json 파일 이름 가져오기(확장자까지 가져와야함)
string filename = "Character.json.json";

// 폴더 경로와 파일이름을 합치기(string fullparh 입력 후 자동완성)
string fullpath = System.IO.Path.Combine(tolderpath, filename);

//Console.WriteLine(fullpath);

// (2) 파일을 읽어오기

string text = File.ReadAllText(fullpath);

//Console.WriteLine(text);

// (3) 파일을 데이터로 해석하기 => class 만들기   

var CharacterDB = JsonConvert.DeserializeObject<List<Character>>(text);

Character selectCharacter = CharacterDB[4];

Console.WriteLine($"Lable : {selectCharacter.Label},\n" +
    $"Name : {selectCharacter.Name},\n" +
    $"Passive : {selectCharacter.Passive},\n" +
    $"Role_1 : {selectCharacter.Role_1},\n" +
    $"Role_2 : {selectCharacter.Role_2}\n" +
    $"Skill_Q : {selectCharacter.SkIll_Q},\n" +
    $"Skill_W : {selectCharacter.SkIll_w},\n" +
    $"Skill_E : {selectCharacter.SkIll_E},\n" +
    $"Skill_R : {selectCharacter.SkIll_R},\n" +
    $"Skin : {selectCharacter.Skin}");

Console.WriteLine("---------------------");


