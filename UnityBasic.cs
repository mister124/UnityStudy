// 1. 변수
// 지역 변수: 함수 안에서 선언된 변수(다른 곳에서 접근 불가)
// 전역 변수: 함수 바깥에서 선언된 변수
// 정수형 데이터
int level = 5;
// 실수형 데이터, 끝에 f
float strength = 15.5f;
// 문자열 데이터, "string", 'char'
string playerName = "나검사";
// 논리형 데이터
bool isFullLevel = true;

// 2. 그룹형 변수
// 길이: .Length
string[] monsters = { "슬라임", "사막뱀", "악마" };
// ex) monsters[0], monsters[1], monsters[2]
int[] monsterLevel = new int[3];
monsterLevel[0] = 1;
monsterLevel[1] = 6;
monsterLevel[2] = 20;
// 기능이 추가된 가변형 그룹 변수: 배열과 다르게 요소 추가, 제거 가능, 길이: .Count
List<string> items = new List<string>;
items.Add("생명물약30");
items.Add("마나물약30");
items.RemoveAt(0);

// Debug.Log("Hello unity!"); // console print

// 3. 연산자
int exp = 1500;
exp = 1500 + 320;
exp -= 10;
level = exp / 300;
strength = level * 3.1f;
int nextExp = 300 - (exp % 300)

string title = "전설의";
Debug.Log(title + playerName);

int fullLevel = 99;
isFullLevel = level == fullLevel;
bool isEndTutorial = level > 10;

int mana = 15;
bool isBadCondition = health <= 50 && mana <= 20; // and 연산자
bool isBadCondition = health <= 50 || mana <= 20; // or 연산자
// 삼항 연산자
string condition = isBadCondition ? "true" : "false";

// 4. 키워드
// 키워드: 프로그래밍 언어를 구성하는 특별한 단어
// int, float string bool new List

// 5. 조건문
if (true)
{
    break;
}
elseif(true) {
    break;
} else (true) {
    break;
}

switch (monster[1])
{
    case "슬라임":
    case "사막뱀":
        break;
    case "악마":
        break;
    case "골렘":
        break;
    default: // 모든 case를 통과한 수 실행
        break;

}

// 6. 반복문
while (true)
{
    health--;
}

for (int count = 0; count < 10; count++)
{
    health++;
}
// 그룹형 변수 탐색 특화
foreach (string monster in monsters)
{
    break;
}

// 7. 함수 (method): 기능을 편리하게 사용하도록 구성된 영역
int Heal(int currentHealth)
{
    currentHealth += 10;
    return currentHealth;
}

void Heal()
{
    health += 10;
}

// 8. 클래스: 하나의 instance와 대응하는 로직
// 접근자: private: 외부 클래스에 비공개, dafault, public: 외부 클래스에 공개;
// Actor player = new Actor();

// Vector3
// transform.position의 타입은 Vector3입니다. Vector3는 3차원 공간에서의 점을 나타내며, x, y, z의 3개의 부동 소수점 숫자로 구성됩니다. 각각의 값은 오브젝트의 세계 좌표계에서의 
// 위치를 나타냅니다
// + 속성
// Vector3.down은 Unity에서 제공하는 Vector3 구조체의 정적 속성 중 하나로, 아래 방향을 나타내는 벡터를 의미합니다. 구체적으로는 Vector3(0, -1, 0)과 동일한 값을 가지며, 이는
// Y축 방향으로 -1 단위만큼을 나타내는 벡터입니다.

// [SerializeField]
// private 변수를 Inspector 창에서 직접 노출시키기 위해 사용됩니다.
// 주의할 점은 [SerializeField] 속성은 Unity에게 해당 변수를 직렬화하고 Inspector 창에서 편집 가능하게 만들어줄 뿐, 해당 변수를 public으로 만들지는 않는다는 것입니다. 
// 따라서 다른 스크립트에서 접근하거나 수정하려면 public 변수로 선언해야 합니다.

// [HideInInspector]
// public으로 선언된 변수는 기본적으로 인스펙터 창에 노출됩니다. 이는 해당 변수를 유저가 인스펙터 창에서 직접 조작할 수 있게 만들어 줍니다. 
// 그러나 [HideInInspector] 속성을 변수 위에 지정하면, 해당 변수를 인스펙터 창에서 숨길 수 있습니다.
// 1. 사용자가 실수로 변수를 변경하지 않도록 보호해야 하는 경우.
// 2. 변수가 내부에서만 사용되며, 외부에서 변경할 필요가 없는 경우.
// 3. 변수가 다른 변수에 의존하는 경우에는 해당 변수를 감추고, 다른 변수를 통해 설정할 수 있도록 하는 경우.

// this 키워드
// this는 클래스 내부에서 현재 인스턴스 자기 자신을 가리키는 데 사용되며, 멤버 변수와 메서드 파라미터 또는 로컬 변수 사이의 이름 충돌을 해결하는 데 유용합니다.

// static
// 정적 변수(Static variable)는 클래스의 인스턴스와 관계없이 클래스 자체에 속하는 변수를 말합니다. 따라서 정적 변수는 클래스의 모든 인스턴스에서 공유됩니다.
// 정적 변수는 인스턴스가 생성되지 않아도 접근할 수 있으며, 클래스 이름을 사용하여 접근합니다. 
// 정적 변수는 클래스의 모든 인스턴스 간에 데이터를 공유하거나, 인스턴스와 무관한 정보를 저장하는 데 사용됩니다.

// Prefab
// 프리팹은 게임에서 재사용되는 오브젝트의 템플릿이며, 미리 정의된 구조와 설정을 가지고 있습니다.

// System.Collections 
// 네임스페이스는 기본적인 컬렉션을 포함하고 있는 .NET Framework의 일부입니다. 이 네임스페이스에는 리스트, 배열, 큐, 스택 등과 같은 
// 데이터 구조와 관련된 클래스들이 포함되어 있습니다.

// System.Collections.Generic 
// 네임스페이스도 컬렉션에 관련된 네임스페이스이지만, 제네릭(Generic) 컬렉션을 포함하고 있습니다. 제네릭 컬렉션은 형식 안전성을 갖추기 위해 만들어졌으며, 
// 다양한 형식의 데이터를 저장할 수 있는 보다 유연한 컬렉션을 제공합니다.

// UnityEngine 
// 네임스페이스는 Unity 게임 엔진에서 사용되는 기본적인 클래스들을 포함하고 있습니다. Unity 게임 개발에 필요한 다양한 기능들을 제공하는 클래스들이
// 이 네임스페이스에 포함되어 있습니다.

// UnityEngine.UIElements
// Unity의 UI 시스템 중 하나인 UI Toolkit의 일부입니다. 이 네임스페이스는 Unity UI를 구성하고 조작하는 데 사용되는 클래스들을 포함하고 있습니다. 
// 이것은 Unity의 기존 UI 시스템(Unity UI)보다 더 강력하고 유연한 UI 작업을 지원합니다.

// TMPro
// TextMeshPro(텍스트 메시 프로) 네임스페이스를 사용합니다. TextMeshPro는 Unity에서 텍스트를 보다 풍부하게 표현할 수 있는 기능을 제공하는 패키지입니다. 
// 폰트 스타일링, 리치 텍스트, 색상, 효과 등을 다양하게 조작할 수 있습니다.

// UnityEditor.PackageManager.UI
// UnityEditor.PackageManager.UI 네임스페이스를 사용합니다. 이는 UnityEditor 패키지 매니저와 관련된 사용자 인터페이스(UI)를 지원합니다. 
// 에디터 확장(Extension)을 개발하거나 에셋을 관리할 때 사용될 수 있습니다.

// UnityEngine.SceneManagement
// UnityEngine.SceneManagement 네임스페이스를 사용합니다. 이는 Unity의 장면 관리와 관련된 클래스를 포함하고 있습니다. 
// Unity에서 장면(Scene)은 게임 내의 환경이나 레벨을 나타내며, 이를 로드하고 언로드하며, 전환하고 관리하는 데 사용됩니다.

// List
private float[] numbers; // ex)

// IEnumerator
//  C#에서 사용되는 인터페이스(interface) 중 하나입니다. 이 인터페이스는 반복 가능한 컬렉션을 나타내는 데 사용됩니다.
// 멤버
// 1. MoveNext() 메서드: 컬렉션에서 다음 요소로 이동하고, 이동이 성공했으면 true를 반환하고, 더 이상 이동할 요소가 없으면 false를 반환합니다.
// 2. Reset() 메서드: 컬렉션의 위치를 초기 위치로 되돌립니다.
// 3. Current 속성: 현재 위치의 요소를 반환합니다.

// yield return new WaitForSeconds(~f);
// 해당 코루틴이 일시 중지되고, 지정된 시간이 지난 후에 다음 코드가 실행되도록 합니다

// 대용량 파일 GitHub upload
// 1. 처음 project 생성 시 Unity에 대한 .gitignore 파일 생성(후에도 생성 가능)
// 파일을 Assets, Packages 등이 있는 곳에 위치
// 2. 위에서 설명했던 위치의 부모 위치에서 Open Git Bash Here 선택
// 3. lfs 관련 입력
// git lfs install
// git lfs "*.zip"
// git add .gitattributes 