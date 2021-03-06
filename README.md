# C_Sharp_Game_Monopoly
# 遊戲畫面
  * 開始選單  
    ![Image](https://github.com/liti2891/C_Sharp_Game_Monopoly/blob/main/game%20menu.jpg)
  * 遊戲畫面1  
    ![Image](https://github.com/liti2891/C_Sharp_Game_Monopoly/blob/main/game1.JPG)
  * 遊戲畫面2  
    ![Image](https://github.com/liti2891/C_Sharp_Game_Monopoly/blob/main/game2.JPG)
  * 創建地圖  
    ![Image](https://github.com/liti2891/C_Sharp_Game_Monopoly/blob/main/map%20generation.JPG)

# 系統流程  
本遊戲多數與傳統大富翁的規則相同，較為特殊的地方是在玩家擲骰子之前可以先選擇是否要使用道具，而我們會設計各種不同的道具來增加遊戲的樂趣，
另外在特殊地點的部分，不同於傳統大富翁，我們設計了更多的地點及不同的功能。
* 在玩家移動到機會命運上時，會隨機抽出一張效果卡片，經過不同的效果來增加遊戲樂趣。
* 在玩家移動到特殊地點時，會觸發不同的效果，以醫院為例：會讓玩家骰子多1顆。  
![Image](https://github.com/liti2891/C_Sharp_Game_Monopoly/blob/main/process%20chart1.png)
![Image](https://github.com/liti2891/C_Sharp_Game_Monopoly/blob/main/process%20chart2.png)

# 作法  
在此專案中，玩家、地圖、機會命運、動畫等等都是以檔案的方式儲存，在執行時，去讀取對應的檔案，使用這樣的方法可以大大的增加遊戲的擴充性，而玩家如果有自己喜歡的角色，都可以直接將資料內的圖片作替換，也可以在機會命運的資料直接加上自己設計的效果，在遊玩時，便會出現自製的功能來!  
* 玩家
```
玩家使用PictureBox來顯示，並用以不同的變數來記錄玩家目前的狀態，例如目前位置、擁有金額、土地…等等。
```
* 地圖
```
地圖同樣採用圖片的方式來呈現，而玩家所移動到的位置則是根據圖片上的座標而定，在各個地點有著自的座標，地圖本身的形式則是去讀取地圖的資料檔。
```
* 房屋
```
當玩家建立房屋後，會直接畫在地圖上，並且玩家升級過房屋的次數會以數字的方式畫在房屋上，這樣可以減少大量地使用PictureBox，也可以省去跟人物重疊的麻煩。
```
* 特殊事件
```
在地圖上繪製的特殊地點它的特殊事件，使用固定的效果，踩上去便執行對應的程式碼，而機會命運目前使用隨機抽取效果的方式來執行，機會命運的效果也是在資料內，資料內則有向前走幾步、獲得的金額…等等。
```
* 擲骰子
```
擲骰子則是用亂數決定擲出1~6的數值，擲出骰子後，玩家所要移動的距離。會以擲出的數值乘上玩家所擁有的骰子數，乘出的結果就是玩家要移動的距離了。
```
* 土地交易
```
以變數紀錄該地是否有人擁有，若無人擁有才可購買，其他玩家擁有則要給付過路費(土地價值*玩家升級次數)，土地為自己所有時，則可以對其做升級的動作。
```
# 資料說明
**以下＿ｎ表示數字**
---
「Ｉｍａｇｅ」資料夾  
```
Map_n.png：地圖圖片  
Character_n.png：角色圖片  
Car.png：汽車圖片  
Scooter.png：機車圖片  
House_n.png：房屋圖片  
```
---
「Ａｎｉｍｅ」資料夾  
```
Roll_n.gif：骰子動畫  
Buy.gif：買地動畫  
Upgrade.gif：升級土地動畫  
Pay.gif：繳交過路費動畫  
Hospital.gif：醫院動畫  
Jail.gif：監獄動畫  
```
---
「Ｓｏｕｎｄ」資料夾  
```
BGM.wav：背景音樂  
Click.wav：按鈕音效  
Hospital.wav：醫院音效  
Jail.wav：監獄音效  
Pay.wav：購買/升級土地、付過路費音效  
ROLL.wav：骰子音效  
```
---
「ＭａｐＤａｔａ＿ｎ.ｔｘｔ」地圖資料  
**<說明內容>  
```
玩家起始金額			[地圖1.為10萬]  
地圖總格數			[地圖1.為31格]  
0(起點):287(X):39(Y):起點(地名)	[地圖1：5種地點]  
1(普通地):331:81:金山  
2(機會):416:165:機會  
3(命運):540:293:命運  
4(監獄):625:231:監獄  
5(醫院):257:516:醫院  
```
---
「Ｏｐｐｏｒｔｕｎｉｔｙ.ｔｘｔ」機會/命運資料  
|類型|金錢變動量|暫停回數|傳送到某地|訊息視窗標題|訊息視窗內容|
|----|---------|-------|---------|-----------|-----------|
|0  |Y         |N      |N        |Y          |Y          |
|1  |Y         |Y      |N        |Y          |Y          |
|2  |Y         |Y      |Y        |Y          |Y          |
|3  |N         |N      |Y        |Y          |Y          |
