## 重力判定を加える
Add Component -> Physics -> Rigidbody -> check the [Use Gravity]

## Collider (コライダー)
オブジェクト同士の当たり判定

## Physic Material
物質の素材の設定
Physic MaterialをColliderに加えることで、オブジェクト同士が接触した際の摩擦や反発といった物理挙動を設定することができる。

## マテリアルとは
オブジェクトの色や質感の設定データ。

## 2D
### 表示順
Sorting Layer ... オブジェクトのグループ分け
Order in Layer ... 重なり順

### 当たり判定
Box Collider 2D
Polygon Collider 2D  - オブジェクトの形に合わせて当たり判定を生成してくれる
Rigidbody 2D - 重力が働くようにする

プレハブ - オブジェクトをスタンプのように複製して簡単に量産を可能にする機能ß

## UI
### Canvas
* UIオブジェクトを配置するための領域
* Hierarchyウィンドウ上で必ずCanvasの子オブジェクトにし、Canvasの範囲内に配置しないとシーン上に表示されない。

#### Render Mode
Screen Space - Overlay ... 必ず一番手前にUIが表示される。
Screen Space - Camera ... シーンを映すカメラの他にUIを映す専用のカメラを追加できる。
World Space ... Canvasの位置や大きさを自由に設定することが可能となる。

#### Canvas Scaler
* Canvasに追加されるUIオブジェクトのサイズ調整を行うコンポーネント。 
* UI Scale Mode
   - ピクセル指定で、デバイス側の解像度やアスペクト比に影響されない。
   - Scale With Screen Size ... スクリーンサイズを基準に自動でUIオブジェクトの拡大・縮小の調整を行う。
   - Constant Physical Size ... インチやミリメートルなど実際の物理的なサイズを基準でUIオブジェクトの大きさを調整する。

### UIオブジェクト
* Anchor ... Canvas上で位置を固定してくれる機能。Anchorの位置を基準として相対位置となる。
* UIオブジェクトの位置は、AnchorとPivotの座標で決まる。
* Pivotは、UIオブジェクトを配置する際の基準となる点。
* 子コンポーネントを作成した場合は、その親UIオブジェクトがCanvasの役割をする
* UIオブジェクトは、他のオブジェクトと同様にプレハブ化して複製することができる。

## Tips
* TextMesh Pro
  - 拡大しても綺麗にテキストが表示され、文字に光を当てて光らせる表現が可能なオブジェクト。
- Imageオブジェクト
  - 画像のTexture TYpeは「Sprite(2D and UI)」にしておく必要がある。
