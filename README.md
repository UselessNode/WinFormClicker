# WinFormClicker

Простой авто-кликер, написанный на C# с использованием .NET Framework 4.8. Этот инструмент позволяет автоматизировать клики мыши в заданной позиции с настраиваемым количеством кликов и интервалом.

![App screenshot](Screenshots/Auto.png)

## 📦 Установка

1. **Клонируйте репозиторий:**

   ```bash
   git clone https://github.com/yourusername/WinFormClicker.git
   ```

2. **Откройте проект в Visual Studio:**

   - Убедитесь, что у вас установлен .NET Framework 4.8.
   - Откройте файл `Auto.sln`.

3. **Соберите проект:**

   - Нажмите `Build` -&gt; `Build Solution` или используйте `Ctrl+Shift+B`.

## 🚀 Использование

1. **Выбор позиции клика:**

   - Нажмите кнопку "Выбрать позицию".
   - Кликните на экране, чтобы задать место для авто-кликов.

2. **Настройка параметров:**

   - Установите количество кликов через поле ввода или слайдер.
   - Настройте интервал между кликами (в миллисекундах).

3. **Запуск авто-кликера:**

   - Нажмите кнопку "Старт".
   - Следите за процессом через прогресс-бар и счётчик кликов.

## 💻 Фрагмент кода

Вот пример кода, который запускает авто-кликер:

```csharp
private void buttonStart_Click(object sender, EventArgs e)
{
    int clickCount = (int)numericUpDownClicks.Value;
    int interval = (int)numericUpDownInterval.Value;
    for (int i = 0; i < clickCount; i++)
    {
        Cursor.Position = new Point(x, y); // Установка позиции курсора
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); // Симуляция клика
        Thread.Sleep(interval); // Пауза между кликами
    }
}
```
