// Start()    
void Start()
{
    pass
}
// Start is called before the first frame update


// Update()
void Update() 
{
    pass
}
// Update is called once per frame 


// Destroy()
Destroy(gameObject, 파괴 전 대기 시간(초)); 

// OnTriggerEnter2D(Collider2D other)
private void OnTriggerEnter2D(Collider2D other) {
    if (other.gameObject.tag == "Coin") {
        // 코인과의 충돌 로직 처리
        Destroy(other.gameObject); // 코인 게임 오브젝트 파괴
    }
}
// Collider2D 컴포넌트가 다른 Collider2D 컴포넌트와 겹쳤을 때 자동으로 호출되는 함수로, 한 오브젝트의 Collider가 "Is Trigger" 옵션이 활성화되어 있고, 
// 다른 오브젝트의 Collider와 겹칠 때 이벤트를 처리하기 위해 사용됩니다.
// 충돌하는 오브젝트의 Collider2D 컴포넌트에 대한 참조를 매개변수 other로 받습니다. 

// Instantiate()
Instantiate(coin, transform.position, Quaternion.identity); // ex)
// coin: 새로 생성될 오브젝트의 프리팹(Prefab)을 나타냅니다. 
// transform.position: 새로운 오브젝트가 생성될 위치를 나타냅니다. 
// Quaternion.identity: 새로운 오브젝트의 회전을 나타냅니다. Quaternion.identity는 회전하지 않은 기본 회전을 의미합니다.

// Input.GetAxisRaw()
// Input.GetAxisRaw("Horizontal") 및 Input.GetAxisRaw("Vertical")은 Unity에서 사용자 입력에 대한 값을 가져오는 함수입니다.
// 1. Input.GetAxisRaw("Horizontal")은 수평 방향(좌우)의 입력 값을 가져옵니다. 이 함수는 -1, 0, 1의 값을 반환합니다. 
// 왼쪽 방향키(←)를 누르면 -1, 오른쪽 방향키(→)를 누르면 1, 아무 키도 누르지 않았을 때는 0의 값을 반환합니다.
// 2. Input.GetAxisRaw("Vertical")은 수직 방향(상하)의 입력 값을 가져옵니다. 마찬가지로 -1, 0, 1의 값을 반환합니다. 
// 아래 방향키(↓)를 누르면 -1, 위 방향키(↑)를 누르면 1, 아무 키도 누르지 않았을 때는 0의 값을 반환합니다.
// 이 함수들은 주로 플레이어가 게임에서 키보드 또는 컨트롤러를 사용하여 캐릭터를 움직일 때 사용됩니다. 
// 수평 및 수직 입력에 따라 플레이어 캐릭터를 움직이는 등의 동작을 구현할 때 많이 사용됩니다.

// Input.GetKey()
// Input.GetKey(KeyCode.RightArrow)는 해당 키(오른쪽 화살표 키)가 눌려있는 동안에만 true(1)를 반환하고, 그렇지 않으면 false(0)를 반환합니다.
// Input.GetKey(KeyCode.LeftArrow)는 해당 키(왼쪽 화살표 키)가 눌려있는 동안에만 true(1)를 반환하고, 그렇지 않으면 false(0)를 반환합니다.

// Camera.main.ScreenToWorldPoint(Input.mousePosition)
// Input.mousePosition을 사용하여 현재 마우스의 위치를 가져온 후, ScreenToWorldPoint 함수를 사용하여 스크린 좌표를 월드 좌표로 변환합니다. 
// 이렇게 하면 마우스 커서의 위치를 게임 월드에서 사용할 수 있게 됩니다.

// Mathf.Clamp(매개변수, 하한, 상한)
// ex) Mathf.Clamp(mousePos.x, -3f, 3f)
// Mathf.Clamp 함수는 특정 값의 범위를 제한하는 함수로, 첫 번째 매개변수의 값을 두 번째 매개변수와 세 번째 매개변수로 주어진 범위 안으로 제한합니다.

// StartCoroutine(), StopCoroutine()
// StartCoroutine()은 Unity에서 사용되는 함수로, 코루틴(Coroutine)을 시작하는 데 사용됩니다.
// StopCoroutine()은 Unity에서 사용되는 함수로, 코루틴(Coroutine)을 중지하는 데 사용됩니다.
// 코루틴은 Unity에서 비동기적인 작업을 처리하기 위한 기능으로, 일종의 "실행 중단 함수"입니다. 일반적인 함수처럼 호출되지만, 
// 중간에 실행이 중단되고 재개되는 기능을 갖추고 있습니다. 이를 통해 시간 지연, 반복적인 동작, 일시 중지 등 다양한 작업을 수행할 수 있습니다.
// 일반적으로 코루틴은 특정 조건을 만족할 때까지 반복되는 무한 루프보다는, 일정 횟수의 반복이나 특정 조건을 충족할 때까지 반복되도록 구현됩니다.

// FindObjectOfType<Class>()
// Scene에서 특정 타입의 오브젝트를 찾아서 가져오는 역할을 합니다.
// 만약 Scene에 특정 타입의 오브젝트가 여러 개 있다면, 첫 번째로 발견된 오브젝트를 반환합니다.

// Invoke("MethodName", second)
// 지정된 메서드를 일정 시간이 지난 후에 실행하는 역할을 합니다.

// Awake()
void Awake() {
    pass
}