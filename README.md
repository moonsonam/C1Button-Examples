# C1Button Example

This repository contains an example demonstrating the usage of the `C1.Win.Input.C1Button` control from the ComponentOne library.

## Example Overview

The example shows how to:
- Initialize a `C1Button`.
- Set its properties, such as `Text`, `DialogResult`, `Trimming`, and `Location`.
- Handle its `Click` event.

### Code Snippet
```csharp
var btn = new C1Button
{
    Text = "Submit",
    Location = new Point(10, 20),
    DialogResult = DialogResult.OK,
    Trimming = StringTrimming.EllipsisCharacter,
};

// Add the button to the form
Controls.Add(btn);

// Handle the click event
btn.Click += (sender, e) =>
{
    MessageBox.Show("C1Button clicked!");
};
