# Toastr.Winforms

Toastr.Winforms is a lightweight and customizable toast notification library for Windows Forms applications. It provides an easy way to display success, error, and warning messages in a visually appealing and non-intrusive manner.

## Features

- **Toast Positioning:** Choose from predefined positions (TopLeft, TopRight, TopCenter, BottomLeft, BottomRight, BottomCenter) for displaying toast notifications.
- **Customizable Duration:** Set a custom duration for how long the toast notification should be displayed.
- **Success, Error, and Warning Notifications:** Easily show success, error, and warning messages with built-in icons and colors.

## Installation

To use **Toastr.Winforms** in your Windows Forms project, follow these steps:

1. Download the Toastr.Winforms package from [NuGet](https://www.nuget.org/packages/Toastr.Winforms/).
2. Install the package using the NuGet Package Manager Console or the Package Manager UI.

## Usage

```csharp
using Toastr.Winforms;

// Create a new toast notification
var toast = new Toast(ToastrPosition.TopRight, duration: 3000);
// Or you can use defaults: var toast = new Toast();

// Show a success notification
toast.ShowSuccess("Operation successful!");

// Show an error notification
toast.ShowError("An error occurred.");

// Show a warning notification
toast.ShowWarning("This is a warning message.");

// You can also customize the toast message
toast.ShowSuccess("Custom success message");

// The toast notification will automatically close after the specified duration.
