// 생성
// ex) public class Player : MonoBehaviour
// : (콜론): 클래스가 다른 클래스를 상속받을 때 사용되는 키워드입니다. 여기서는 MonoBehaviour 클래스를 상속받습니다.
// MonoBehaviour: Unity에서 모든 스크립트 클래스가 상속받는 기본 클래스입니다. MonoBehaviour 클래스는 Unity의 게임 오브젝트에 부착하여 스크립트로서 작동할 수 있도록 합니다. 
// 이 클래스는 Unity에서 제공하는 다양한 기능과 이벤트에 접근할 수 있도록 해줍니다.

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
// + 주요 특징과 기능:
// 1. 컴포넌트 시스템: GameObject는 여러 개의 컴포넌트(Component)를 부착하여 기능을 확장할 수 있습니다. 
// 예를 들어, Transform 컴포넌트는 모든 GameObject에 기본적으로 포함되어 있으며, 오브젝트의 위치, 회전, 크기를 정의합니다.
// 추가적으로 Rigidbody, Collider, MeshRenderer 등 다양한 컴포넌트를 부착하여 오브젝트에 물리적인 속성, 충돌 감지 기능, 시각적 표현 등을 추가할 수 있습니다.
// 2. 계층적 구조: 하나의 GameObject가 다른 GameObject의 자식이 될 수 있으며, 이를 통해 복잡한 씬(Scene) 구조를 효율적으로 관리할 수 있습니다.
// 3. 동적 생성 및 제어: 스크립트를 통해 GameObject를 동적으로 생성하고, 속성을 수정하거나, 행동을 제어할 수 있습니다. 이를 통해 게임의 동적인 요소들을 구현할 수 있습니다.
// 4. 다양한 유틸리티 함수들: GameObject 클래스는 SetActive(), GetComponent<>(), Destroy() 등 다양한 유틸리티 함수들을 제공합니다. 이러한 함수들은 게임 오브젝트의 
// 활성화 상태를 변경하거나, 부착된 컴포넌트를 가져오거나, 오브젝트를 제거하는 등의 작업을 수행할 때 사용됩니다.

// Transform
// Transform 클래스는 Unity에서 모든 게임 오브젝트(GameObject)에 기본적으로 포함되어 있는 컴포넌트 중 하나입니다. 이 클래스는 게임 오브젝트의 위치, 회전 및 크기를 관리합니다.

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
    void Awake() {
    if (instance == null) {
        instance = this;
        }
    }
}

// TextMeshProUGUI
// Unity에서 사용되는 텍스트 컴포넌트 중 하나입니다. Unity에서는 기본 텍스트 컴포넌트인 Text보다 더 많은 기능과 유연성을 제공하는 TextMeshPro 시스템을 제공합니다.
// method
// 1. SetText("String")
// "String"으로 text 설정
