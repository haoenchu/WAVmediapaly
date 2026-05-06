# 🎵 WAV Media Player (C# WinForms)

這是一個使用 C# 與 Windows Forms (WinForms) 開發的輕量級 WAV 音效檔播放器。專案結合了基礎的 UI 設計與強大的 **NAudio** 音訊處理套件，實作了現代音樂播放器必備的核心功能。

<img width="717" height="278" alt="螢幕擷取畫面 2026-05-06 084443" src="https://github.com/user-attachments/assets/f7cabf84-3d95-4cf0-9932-f1fc980b7dc9" />

## ✨ 核心功能

*   **📂 本地檔案讀取**：支援透過 `OpenFileDialog` 瀏覽並載入 `.wav` 格式的音效檔。
*   **▶️ 基礎播放控制**：包含播放、暫停 (從原點繼續)、以及防呆機制 (未選擇檔案無法播放)。
*   **🎚️ 動態進度條 (SeekBar)**：
    *   隨音樂播放即時平滑更新。
    *   支援滑鼠拖曳 (Seek) 自由跳轉播放進度。
    *   同步顯示當前播放時間與總時長 (mm:ss)。
*   **🔊 音量控制**：透過滑桿 (TrackBar) 即時調整輸出音量 (0% - 100%)。
*   **🔁 單曲循環 (Looping)**：一鍵切換循環播放模式，具備 UI 狀態回饋 (顏色變化)，並自動無縫接軌進度條。
*   **🛡️ 穩定性設計**：
    *   處理跨執行緒 UI 更新 (`Invoke`)，防止播放結束時程式崩潰。
    *   完整的資源釋放 (`Dispose`)，避免記憶體洩漏與檔案鎖定問題。

## 🛠️ 技術棧與依賴套件

*   **語言**: C# (.NET Framework)
*   **UI 框架**: Windows Forms
*   **核心音訊引擎**: [NAudio](https://github.com/naudio/NAudio) (透過 NuGet 安裝)

## 🚀 如何運行此專案

### 前置需求
*   安裝 [Visual Studio 2019/2022](https://visualstudio.microsoft.com/) (包含 .NET 桌面開發工作負載)。

### 步驟
1.  將此儲存庫 Clone 到本地：
    ```bash
    git clone [https://github.com/你的帳號/WAVmediapaly.git](https://github.com/你的帳號/WAVmediapaly.git)
    ```
2.  使用 Visual Studio 開啟方案檔 (`WAVmediapaly.sln`)。
3.  **還原 NuGet 套件**：
    *   在方案總管中，對專案點擊右鍵 -> 選擇「管理 NuGet 套件」。
    *   確認已安裝 `NAudio` (版本建議為最新穩定版)。
4.  按下 `F5` 或點擊「開始」編譯並運行程式。

## 🧠 開發筆記與學習點

開發過程中解決了以下關鍵技術問題：
1.  **取代 `SoundPlayer`**：由於內建的 `System.Media.SoundPlayer` 不支援進度讀取與音量控制，全面改寫為 `NAudio.WaveOutEvent` 來獲取底層控制權。
2.  **UI 同步與防呆**：利用 `Timer` 處理進度條更新，並透過 `MouseDown/MouseUp` 事件解決自動更新與手動拖曳的衝突。
3.  **執行緒安全**：在處理 NAudio 的 `PlaybackStopped` 事件時，學習到必須使用 `this.Invoke` 將控制權交回 UI 執行緒，以安全地更新按鈕狀態與進度條。

## 🤝 貢獻與建議

這是一個學習與練習性質的專案。如果您有任何改進建議（例如增加 MP3 支援、美化 UI 等），歡迎發起 Issue 或提交 Pull Request！

## 📄 授權條款

本專案採用 [MIT License](LICENSE) 授權。
