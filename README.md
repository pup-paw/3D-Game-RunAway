# Run Away

### 게임 설명

- 제목 : Run Away (도망쳐)
- 장르 : 어드벤처 게임
- 시나리오 : 우리에 침입한 천적인 동물들을 피해 모이를 모두 먹어야 한다.
- 플레이 방법

- 움직임 : 방향키를 이용하여 캐릭터의 방향을 조절한다.

- 점프 : space bar을 이용하여 높은 곳으로 점프해서 올라간다.

<br>

### 게임월드 구성 및 주요 기능

- player 🐔
  1. 앞, 뒤, 좌, 우로 이동이 가능하다.
  2. 점프를 통해 높은 곳으로 올라갈 수 있다.
  3. 천적인 다른 동물들과 닿으면 피를 뿜으며 죽는다.
  4. 먹이인 잡초를 먹을 수 있고, 먹을 때마다 score가 올라간다.

<br>

- npc 🐶🐱🦁
  1. 앞, 뒤, 좌, 우로 움직일 수 있다.
  2. player의 움직임을 따라 움직인다.
  3. 점프는 할 수 없다.
  4. 고양이는 2, 개는 3, 사자는 4의 속도를 가지고 있다.
  5. palyer인 닭과 닿으면 닭이 사라진다.

<br>

- grass 🌱
  1. 1개당 score 1점이다.
  2. 총 50개까지 먹을 수 있다.
  3. 50개를 먹을시 player가 승리하며 게임이 끝난다.

<br>

- camera 📹
  1. player를 따라다닌다.
  2. 방향은 고정되어 있고, 장애물 뒤는 보여주지 않는다.

<br>

- game control 🎮
  1. player의 체력이 0이 되면 game over 화면을 띄워wnsek.
  2. 사용자가 game over 화면을 클릭하면 다시 게임을 시작한다.
  3. player가 모은 grass의 개수가 최대(50개)가 되면 you win 화면을 띄워준다.
  4. 사용자가 you win 화면을 클릭하면 다시 게임을 시작한다.

<br>

### 게임 실행 화면 캡처

- 게임 시작 화면
  ![그림1](https://user-images.githubusercontent.com/69156709/130655980-56c2cf3b-dc86-4a3b-9916-1cd9462b847a.png)
- 점프한 화면
  ![그림1](https://user-images.githubusercontent.com/69156709/130656132-3b7ed19b-6d79-4204-8f9b-ea830a977ee8.png)
- npc와 충돌하여 game over한 화면
  ![그림1](https://user-images.githubusercontent.com/69156709/130656252-70505d4f-1b23-4cf3-8cbc-382c5069083e.png)
- you win 화면 (grass를 최대인 50개를 먹어 score가 50이 된 상태)
  ![그림1](https://user-images.githubusercontent.com/69156709/130651900-da608f15-6a72-4638-b2ee-f7c9b5cd44c1.png)
