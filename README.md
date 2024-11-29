# File Openor(Ver.1)
[最新版はここから](https://github.com/tm20205/File-Openor/releases/)  
↓かreadmeは読んでね。

# ！注意！
  このプログラム等でなにかしらの損害を被っても当方は一切責任を負いません。自己責任ってやつ。  
 

# なぁにこれぇ？
　フォルダー（最大4つ）、ソフトとかプログラムとか（最大4つ）を自動で開くことができます。（そうでないこともある（後述））


# 内容物
File Openor.exe ←本体  
adjustor.exe　←位置調整機能。Python必須。独立して動作可能。別途取説参照。  
adjustor_debug.exe　←デバッグ用のadjustor。普段は使わない。詳細は「位置調節機能取扱とりせつ.txt」にて。  
File Openor-setting.exe　←Path書き込んでくれるやつ。  
  
File Openor-setting内  
　なんかいっぱいある.csファイルとか　←File Openor-setting.exeのコンパイル前ファイル。  
  
Read_Path内  
　adjustor_Apply.ini　←adjustorの機能を有効\無効を設定するやつ。  
　adjustor_setting.ini　←設定した座標や幅、高さなんかを記録してる。  
　debug.ini　←デバッグ用。詳細は「位置調節機能取扱とりせつ.txt」にて。  
　Path.ini　←フォルダーとかファイルとかのパスを書くやつ。  
　WindowName.ini　←ウィンドウのタイトルを保存してる。自動で取得するのは諦めた。；；  
  
src内  
　File Openor.cs ←本体のもとのファイル（調整する場合はこちらから）  
　adjustor.cs　←adjustorの元のファイル（中身を見たい人向け。もう少しきれいにできそう。）  
　adjustor_debug.cs　←adjustor_debugの元のファイル（上に同じく）  
　  
Readme.txt ←これと同じやつ書いてます。よんでえらい！  
位置調節機能取扱とりせつ.txt ←adjustor.exeの取説。使うならどうぞ。  
adjustorの使い方1.jpeg　←とりせつで使うかも。  

# File Opneorの使い方
　自動で開きたいフォルダーのパスを File Openor-setting.exe を起動して、テキストボックス内に１個ずつ書いてください。  
　（フォルダのパスでなくても.exeや.txt、.docxとかでも動くと思いますが、うまくいかないことがあるかもしれません。試してみて動いたらおｋです。）  
　（例）C:\hoge\hogehoge  
　  
　また、自動で起動したいソフトやプログラムを File Openor-setting.exe を起動して、テキストボックス内に１個ずつ書いてください。  
　（.exeでなくても.txtや.docxとかでも動くと思います。また、ショートカット（リンク→.lnkや.url）を指定しても動きます。うまく行かない時はショートカットにするといいかも。）  
　（例）C:\hogehoge\hoge.exe  
  
　書けたら File Openor.exe をダブルクリック/実行してください。  
　（実行中は操作しない方が良さそう。正常動作しないかも。開発者側では誤作動しなかった。）  
　  
　そんなに使わねぇよ！！って方はボックス内を空白状態（何も書かない）にしてください。  
　（間違ったパス/何かを書いてしまうと、どこかのフォルダーが表示されます。）  
　  
　！日本語には対応したけどなんか日本だと見ない漢字（非常用漢字など）は普通に読めない可能性があるので、うまくいかなければ諦めてファイル名変えてください。！  
  
　こいつには位置調整機能や多重起動防止機能があります。使いたい方は「位置調整機能とりせつ.txt」をご参照ください。  
  
  
# おい動かねぇぞ！！！そんなときは
　・パスに普通じゃない非常用漢字とかが入っていませんか？このプログラムは普通じゃない非常用漢字とかは普通に読めないかもしれないので拒否る可能性があります。気をつけろぉ！！（動作未確認）  
　・ショートカットの名前も上に同じ  
　・そもそもパスや名前が間違ってたりして...  
　・実行中にマウスクリックしたりしてませんか？  
  
  
# プログラムについて（どんなプログラムか知りたい人向け。へんt...ｹﾞﾌﾝｹﾞﾌﾝ）
　最初の11行目-34行目で.iniファイルの読み込みをしています。行で分けて管理するため、行ごとにリストに入れることにしました。  
　36行目-59行目で、リストをわかりやすいように変数に代入してます。正直動けばいいのなら、いらない。  
　61行目-138行目はフォルダーを開くプログラム。if文で.ini内が空の状態でない時実行されます。更に多重起動防止が有効時、ウィンドウのタイトルからハンドルを取得し、それが存在しなければ起動するようにif文を組んでいます。一応try内にすることで、記入ミスでエラーになった際にその後も止まらず動作できるようにしています。  
　140行目-206行目はソフト等を開くプログラム。try文で.ini内が空だったり間違ったものが書かれているとスキップして次のプログラムが走ります。ここも多重起動防止が有効の場合フォルダー時と同じ動きをします。  
　208行目-最後はおまけの位置調節機能が自動で起動するプログラムです。本体と同じC#で作ったのでそこそこな速度のはずですが実行中触らないよう注意です。  
　ちなみに98％ウェブページ産です。ウェブに書いてくれた人に感謝です。  
　（※v.1でここはもう更新しないことにします。バージョンアップで全く合わなくなるかも。もう書くこと多すぎ笑えない。）  


# バージョンログ/Change log
　ver1　　Readmeを更新しました。まさにこことか。  
　　　　　adjustorをexeにしました。（これによりpython未導入でも使用可能に）  
　　　　　adjustor.pyを同梱しなくしました。↑があればいらなくね？？？と思いましたまる（もし必要なら前バージョンから持ってきてください）  
　　　　　見えないところですが、手前に表示する機能がより安定する用になりました。  
　　　　　adjustor_debugを追加しました。どこでエラーを吐いてるかわかるようになりました。（なんかうまくいかない or デバッグ情報をみてｸﾞﾍﾍ･･･したい人向け）  
　　　　　adjustor_debugを追加したことに伴い、「位置調節機能取扱とりせつ.txt」を更新しました。デバッグモードに関する記載を追加しました。  
　　　　　adjustorにループ機能を追加しました。これで起動するまで自動で探し続けてくれます。  
　　　　　adjustorに多重起動防止機能を追加しました。ミスで一つだけ閉じてしまったときとかに使えるかもしれません。  
　　　　　File Openor-PathwriterをFile Openor-settingに改名しました。機能詰め込み過ぎてもはやPathwriterではない。  
　　　　　Read_Path内のファイルを一新しました。あのままだとファイルの数がやばくなる…  
　　　　　Read_Path内のファイルの拡張子を.iniにしました。これにした理由は…なんとなくそれっぽいから。  
  
　　　　　※余談　Python版adjustor、Python導入だけでは動かない模様。本当に申し訳ない。（たしかwin32guiを導入しないと動かないはず）  
　ver0.21 PathWriterで書き込むと謎の改行等が出るのを修正。  
　ver0.2 日本語パスに対応しました。  
　　　　　プログラム起動数を2→4に増やしました。  
　　　　　パスを書くためのソフト(File Openor-PathWriter.exe)を付属しました。  
　　　　　並びの関係でadjustor.pyの名前をz_adjustor.pyに変えました。中身は同じです。  
　ver0.1 リリース。  
  

# 作者より
  個人的にはもう追加する機能はないかと思います。  
  俗に言うネタ切れ。  
  まぁ今回導入を断念したウィンドウの名前を自動で記入してくれる機能は、できたら追加するかもしれません。  
  
製作者 Twitter: @tm20205
