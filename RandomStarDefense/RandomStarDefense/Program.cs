
using RandomStarDefense;
using Newtonsoft.Json;

// 폴더에서 케릭터, 몬스터 파일경로 가져오기

using System.Text.Json.Serialization;

string tolderpath = "C:\\Users\\gudrm\\GitHub\\25_CSharp\\RandomStarDefense\\RandomStarDefense";

string CharacterFileName = "Character.json";

string MonsterFileName = "Monster.json";

string CharacterFullPath = Path.Combine(tolderpath, CharacterFileName);

string MonsterFullPath = Path.Combine(tolderpath, MonsterFileName);

// 파일 읽어오기

string CharacterText = File.ReadAllText(CharacterFullPath);

string MonsterText = File.ReadAllText(MonsterFullPath);

// 파일을 데이터로 해석하기 =>  class 만들기

var CharacterDB = JsonConvert.DeserializeObject<List<Character>>(CharacterText);

var MonsterDB = JsonConvert.DeserializeObject<List<Monstar>>(MonsterText);

