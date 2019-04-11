〇 UploadPlatformChecker

SceneViewの左上に選択中のBuild Platformを表示したり、切り替えたりできるUnityエディタ拡張です。
VRChatでOculusQuest用にアバターやワールドをアップロードする際に使用することを想定しています。

〇 使い方
 - UploadPlatformChecker.unitypackageを使いたいプロジェクトにインポートします。
 - 現在選択しているPlatformが"PC"または"Android"または"Other"と表示されます。
 - 「PC」: Bulid（アップロード）するPlatformをPC向けに切り替えます。
 - 「Android」: Build（アップロード）するPlatformをOculusQuest(Go/Android)向けに切り替えます。
               Android SDKがインストールされていなければこのボタン選択時に下に警告とインストール用のボタンが出てきます。
 - 「Open Build Settings」: Build Settingsを開きます。（Android SDKがインストールされていないときのみ表示）

 〇 Androidへ切り替わらない場合
 Android SDKがインストールされていない可能性が高いです。
 「Android」ボタンを押した際に表示された「Open Build Settings」を押して表示された画面で
 「Open Download Page」を押して"UnitySetup-Android-Support-for-Editor-XXX.exe"をダウンロードしてください。
 その後, そのexeファイルを起動してAndroid SDKをインストールしてください。

 〇 利用規約・免責事項
 本ツールを使用しておこった問題に対して本ツールの著作者gatosyocoraが一切の責任を負いません。
 本スクリプトはMITライセンスで運用しますのでライセンスの範囲内で使用していただいて構いません。
 MITライセンスの詳しい内容は同封しているLICENSE.txtをご覧ください。

 〇 連絡先
 Twitter : @gatosyocora
 Booth : https://gatosyocora.booth.pm/
