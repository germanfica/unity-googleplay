# unity-googleplay
In this repository googleplay services works correctly. Fix googleplay authentication issue conclusively.

## Fix the authentication issue
Just go to `Assets/germanfica.xyz/Packages` folder and open *plugins.unitypackage*.

## Instructions to make google services work on Android
1. Go to `Player Settings -> Publishing Settings -> Keystore` and create a new key. **Note:** user.keystore file has its own built-in **SHA-1** that must be synchronized with https://console.cloud.google.com/apis/credentials.
2. To get SHA-1 we must run this command in the project root folder:
`keytool -exportcert -keystore germanfica.keystore -list -v`
3. Enter a secure password.
4. Copy the SHA-1 and replace it in the google console.
5. Save your changes and that's it ((:

**Source:**
https://forum.unity3d.com/threads/how-can-i-find-my-signing-certificate-fingerprint-sha1.242094/
https://www.youtube.com/watch?v=ELEsytc5LyU