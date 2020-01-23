# mole-catch-game
60초 동안 두더지를 뿅망치로 잡으면서 점수를 올리는 오큘러스 VR 게임

- 프로젝트 기간 : 2019.03~2019.07
- 팀원 : 김원표, 김태영

![그림1](https://user-images.githubusercontent.com/39265738/72989229-3b740400-3e31-11ea-89f0-9d760abf2787.png)


    [그림1] StartScript.cs
    * deltaTime을 통해서 2초 후에 자동으로 다음 씬으로 넘어가도록 구현

![그림2](https://user-images.githubusercontent.com/39265738/72989477-aae9f380-3e31-11ea-8a30-4efc1709deb0.png)

    [그림2] itemcontroller.cs
    * delta와 span을 이용해 두더지와 폭탄 오브젝트를 위아래로 움직이도록 구현

![그림3](https://user-images.githubusercontent.com/39265738/72989480-aae9f380-3e31-11ea-8386-f3ccc12ddc57.png)
![그림4](https://user-images.githubusercontent.com/39265738/72989482-ab828a00-3e31-11ea-85d4-deddf29d7453.png)
  
    [그림3] HammerContoller / GameDirector.cs
    * BoxCollider을 이용해 뿅망치가 충돌감지를 하고, 두더지인지 폭탄인지 판단해 해당하는 점수를 띄우고 오디오 재생


![그림5](https://user-images.githubusercontent.com/39265738/72989483-ab828a00-3e31-11ea-931c-664fcf971145.png)

    [그림4] GameDirector.cs
    * UI에 있는 텍스트를 받아와 20 단위로 속도를 증가시키고 0에 도달하면 다음씬으로 화면 전환

![그림6](https://user-images.githubusercontent.com/39265738/72989863-70348b00-3e32-11ea-975a-c57684819b64.png)

    [그림5] 게임 플레이 사진
