# bubble-sort
## 專案簡介
這是一個 **C# WinForms Bubble Sort 範例專案**，用來展示 **泡沫排序法 (Bubble Sort)** 的運作原理。  
專案同時包含 **輸入檢查功能**，可以驗證使用者輸入是否為合法數字，並有對應的**單元測試 (Unit Test)**。

---

## 功能說明
1. **Bubble Sort 排序**  
   - 將使用者在表單輸入的數值進行升冪排序。  

2. **輸入驗證**  
   - 檢查使用者輸入是否為有效數字 (float)。  
   - 若輸入不合法，會提示錯誤並清空對應欄位。  

3. **單元測試**  
   - **SortInputChecker**  
     - 測試輸入合法與非法浮點數的情況。  
   - **BubbleSorting**  
     - 測試排序是否正確升冪排列。  
     - 測試交換函數 `SwapValue` 是否正常運作。

---

## 使用方式
1. 打開 `BubbleSort.sln` 解決方案 (Visual Studio)。  
2. 編譯並執行 **BubbleSort** 專案。  
3. 於四個欄位中輸入數值，點擊「Sort」按鈕即可看到排序結果。 
