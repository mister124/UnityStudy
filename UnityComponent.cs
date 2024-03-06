// gameObject
// .gameObject은 Unity의 모든 컴포넌트(Component)에 포함된 속성(Property) 중 하나입니다. 이 속성은 해당 컴포넌트가 속한 게임 오브젝트(GameObject)를 참조합니다.

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
