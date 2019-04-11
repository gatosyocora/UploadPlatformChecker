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

--------------------------------------------
This Unity Editor Extension is displayed build platform selected to SceneView.
We can select build platform from this one.
This is used upload Avatar & World Contents for OculuQuest to VRChat.

〇 How to use
 - Import UploadPlatformChecker.unitypackage to your project.
 - It is displayed build platform selected to SceneView.
 - 「PC」: Switch build platform to PC.
 - 「Android」: Switch build platform to Android (OculusQuest).
                If it is not install Android SDK, it is displayed alert and new button.
 - 「Open Build Settings」: Open Build Settings. (When not install Android SDK)

〇 Click Android, but it is not switch "Android" and not display "Android"
  No installed Android SDK very probable.
  Click "Open Build Settings" and Click "Open Download Page" to download "UnitySetup-Android-Support-for-Editor-XXX.exe".
  After, start This exe file to install Android SDK.

〇 Terms of Service/Disclaimer
  This Tool author "gatosyocora" avoid damage you have caused to use this.
  This script is MIT License. You can use free within license.
  This license details is written in LICENSE.txt.

〇 Contact
  Twitter : @gatosyocora
  Booth : https://gatosyocora.booth.pm/
