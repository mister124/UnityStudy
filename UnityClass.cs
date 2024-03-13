// 생성
// ex) public class Player : MonoBehaviour
// : (콜론): 클래스가 다른 클래스를 상속받을 때 사용되는 키워드입니다. 여기서는 MonoBehaviour 클래스를 상속받습니다.
// MonoBehaviour: Unity에서 모든 스크립트 클래스가 상속받는 기본 클래스입니다. MonoBehaviour 클래스는 Unity의 게임 오브젝트에 부착하여 스크립트로서 작동할 수 있도록 합니다. 
// 이 클래스는 Unity에서 제공하는 다양한 기능과 이벤트에 접근할 수 있도록 해줍니다.
// 상속: ex) MonoBehaviour의 멤버변수, 함수 사용 가능

// Rigidbody2D
// Rigidbody2D 클래스는 Unity에서 2D 물리 시뮬레이션을 처리하기 위한 주요 컴포넌트 중 하나입니다.
// ex) Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
// + 주요 기능
// 1. 물리적 속성 설정:  오브젝트의 질량, 중력, 회전 등을 조절할 수 있습니다.
// 2. 동적인 이동 및 회전: 오브젝트에 힘을 가해서 이동하거나 회전할 수 있습니다. 또한, 다양한 속도, 가속도, 각 가속도 등을 설정하여 오브젝트의 동적인 행동을 제어할 수 있습니다
// ex) rigidbody.AddForce()를 사용하여 오브젝트에 힘을 가하거나, rigidbody.velocity를 사용하여 오브젝트의 속도를 변경할 수 있습니다.
// 3. 충돌 감지: 충돌을 감지하고 다른 오브젝트와 상호작용할 수 있습니다. 오브젝트가 다른 오브젝트와 충돌할 때 발생하는 이벤트를 처리할 수 있습니다.
// 4. 트리거 설정: 트리거 옵션을 설정하여 다른 오브젝트와의 충돌을 트리거로 감지할 수 있습니다. 
// 이는 충돌을 통해 물리적인 반응을 일으키지 않고도 특정 이벤트를 발생시킬 수 있습니다.

// GameObject
// Unity에서 게임 오브젝트(GameObject)는 게임의 모든 오브젝트(예: 캐릭터, 아이템, 카메라, 조명 등)의 기본 단위입니다.
// method
// 1. SetActive()
// SetActive(true): 해당 게임 오브젝트와 그 자식들도 모두 활성화합니다.
// SetActive(false): 해당 게임 오브젝트와 그 자식들을 모두 비활성화합니다
// 2. Find()
// 특정 이름을 가진 GameObject를 찾아서 반환합니다. 이 메서드는 문자열 파라미터를 사용하여 검색할 게임 오브젝트의 이름을 지정합니다.
// 지정된 이름과 정확히 일치하는 첫 번째 게임 오브젝트를 찾은 후 반환합니다. 이름이 일치하는 다른 게임 오브젝트가 있더라도, 첫 번째로 찾은 객체만 반환합니다.
// + 주요 특징과 기능:
// 컴포넌트 시스템: GameObject는 여러 개의 컴포넌트(Component)를 부착하여 기능을 확장할 수 있습니다. 
// 예를 들어, Transform 컴포넌트는 모든 GameObject에 기본적으로 포함되어 있으며, 오브젝트의 위치, 회전, 크기를 정의합니다.
// 추가적으로 Rigidbody, Collider, MeshRenderer 등 다양한 컴포넌트를 부착하여 오브젝트에 물리적인 속성, 충돌 감지 기능, 시각적 표현 등을 추가할 수 있습니다.
// 계층적 구조: 하나의 GameObject가 다른 GameObject의 자식이 될 수 있으며, 이를 통해 복잡한 씬(Scene) 구조를 효율적으로 관리할 수 있습니다.
// 동적 생성 및 제어: 스크립트를 통해 GameObject를 동적으로 생성하고, 속성을 수정하거나, 행동을 제어할 수 있습니다. 이를 통해 게임의 동적인 요소들을 구현할 수 있습니다.
// 다양한 유틸리티 함수들: GameObject 클래스는 SetActive(), GetComponent<>(), Destroy() 등 다양한 유틸리티 함수들을 제공합니다. 이러한 함수들은 게임 오브젝트의 
// 활성화 상태를 변경하거나, 부착된 컴포넌트를 가져오거나, 오브젝트를 제거하는 등의 작업을 수행할 때 사용됩니다.

// Transform
// Transform 클래스는 Unity에서 모든 게임 오브젝트(GameObject)에 기본적으로 포함되어 있는 컴포넌트 중 하나입니다. 이 클래스는 게임 오브젝트의 위치, 회전 및 크기를 관리합니다.
// transform.position
// transform.position은 Unity 엔진에서 게임 오브젝트의 위치를 나타내는 속성입니다. Unity의 3D 공간에서 모든 게임 오브젝트는 Transform 컴포넌트를 가지고 있으며, 이 컴포넌트는 
// 게임 오브젝트의 위치(position), 회전(rotation), 크기(scale) 등을 제어합니다.
// + 로컬 위치 vs. 세계 위치
// transform.position은 오브젝트의 세계 위치를 나타냅니다. 이와 대비되는 개념으로 로컬 위치가 있으며, 이는 transform.localPosition을 통해 접근할 수 있습니다. 로컬 위치는 
// 오브젝트의 부모 게임 오브젝트에 대한 상대적 위치를 나타냅니다. 부모 오브젝트가 없는 경우, transform.position과 transform.localPosition은 동일한 값을 가집니다.
// + 주의 사항
// 1. transform.position을 자주 변경하는 것은 성능에 영향을 줄 수 있습니다. 가능하면 물리 엔진을 사용하여 오브젝트를 이동시키거나, 필요한 경우에만 위치를 업데이트하세요.
// 2. transform.position을 수정할 때는 항상 새로운 Vector3 값을 할당하거나, 기존 값을 적절히 수정하는 방법을 사용해야 합니다. 예를 들어, transform.position.x += 1과 같은 
// 직접적인 수정은 허용되지 않으며, 대신 전체 Vector3 값을 새로 할당해야 합니다.

// Vector2
// Method
// MoveTowards(현재위치, 목표위치, 속도혹은 시간): 등속이동 함수

// Time
// 속성
// 1. deltaTime
// Unity에서 프레임 간의 경과 시간을 나타내는 값입니다. 이 값은 이전 프레임과 현재 프레임 사이의 시간 간격을 나타내며, 주로 게임의 물리 업데이트나 애니메이션, 
// 이동 등에서 사용됩니다.
// ex) 30 FPS, 60 FPS -> Time.deltaTime = 0.3333s, 0.01666s
// FPS가 낮을수록 Time.deltaTime이 길어짐 * 일정 속도 = 이동 거리가 길어짐 -> FPS 성능 차이 극복 
// 2. time
// Time.time은 Unity 엔진에서 사용되는 변수로, 현재 게임이 시작된 이후의 경과 시간을 초 단위로 나타냅니다.
// 일반적으로 게임에서는 Time.time을 사용하여 특정 이벤트를 타이밍하거나, 경과된 시간에 따라 게임의 로직을 조작합니다. 예를 들어, 특정 시간 간격마다 적을 생성하거나, 
// 특정 시간이 지나면 플레이어의 체력을 감소시키는 등의 동작을 구현할 수 있습니다.

// Random
// 함수
// 1. Range(min, max)
// 두 정수 사이의 랜덤한 값을 반환합니다. 이 때 반환되는 값은 첫 번째 매개변수(min) 이상이고, 두 번째 매개변수(max) 미만인 정수값입니다.

// SceneMAnager
// method
// 1. LoadScene("SceneName")
// "SceneNanme"이라는 이름의 Scene을 로드합니다

// GameManager
// 일반적으로 게임 매니저는 게임 내에서 전반적인 상태를 관리하고 중요한 게임 플레이 요소를 조정합니다. 
// 예를 들어, 게임 진행 상태, 플레이어 점수, 게임 오버 여부 등을 관리할 수 있습니다.
// GameManager.instance는 게임 매니저의 싱글톤(Singleton) 인스턴스를 가리킵니다. 싱글톤은 어플리케이션 내에서 단 하나의 인스턴스만을 유지하는 디자인 패턴으로, 
// 보통 게임 매니저와 같이 전역적으로 접근되어야 하는 객체에 사용됩니다.
// SetGameOver()는 게임 매니저의 메서드로, 게임이 종료되었음을 표시하고 필요한 후속 작업을 수행할 수 있습니다. 이 메서드는 보통 게임 오버 상태를 설정하고, 
// 게임 오버 화면을 표시하거나 게임 재시작 옵션을 제공하는 등의 동작을 수행합니다.
//  Unity에서 사용되는 싱글톤(Singleton) 패턴을 구현하는 일반적인 방법
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}

// TextMeshProUGUI
// Unity에서 사용되는 텍스트 컴포넌트 중 하나입니다. Unity에서는 기본 텍스트 컴포넌트인 Text보다 더 많은 기능과 유연성을 제공하는 TextMeshPro 시스템을 제공합니다.
// method
// 1. SetText("String")
// "String"으로 text 설정

// Resources
// method
// LoadAll<T>(string path)
// 지정된 경로 내의 모든 리소스를 로드하고, 이를 배열 형태로 반환합니다. 여기서 T는 로드하려는 리소스의 타입을 나타냅니다
// 이 방법은 주로 다음과 같은 경우에 유용합니다:
// 주사위 게임에서 각 면에 해당하는 다양한 스프라이트 이미지를 로드할 때.
// 로드할 리소스의 정확한 이름을 모르거나, 동적으로 여러 리소스를 로드해야 할 때.
// 그러나, Resources 폴더를 사용하는 것은 빌드 시 해당 폴더의 모든 내용이 게임에 포함되기 때문에, 게임의 크기가 불필요하게 커질 수 있습니다. 또한, 로드 시간이 길어질 수 있으므로, 
// 필요한 리소스만 정확하게 관리하는 것이 좋습니다. 대안으로, AssetBundles이나 Addressables 같은 시스템을 사용하여 더 효율적으로 리소스를 관리하고 로드할 수 있습니다.
// ex) Resources.LoadAll<Sprite>("DiceSides/");
// "Assets/Resources/DiceSides" 경로에 있는 모든 Sprite 리소스를 로드하고, 배열 형태로 반환 