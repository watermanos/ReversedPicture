# Reversed Picture Carousel
This project reads an HTML file containing a carousel of images, reverses the order of the images, and saves the modified HTML file to a specified output folder. This functionality is useful when you need to reverse the sequence of images in a carousel without manually editing the HTML.

## Features
* **Select Input File:** Prompts the user to select an HTML file containing images.
* **Select Output Folder:** Allows the user to specify a folder to save the modified HTML file.
* **Reverse Image Order:** Automatically reverses the order of images within the carousel.
* **Save Modified HTML:** Saves the modified HTML file with reversed images to the chosen folder.
  
## Prerequisites
* **HtmlAgilityPack:** This project requires the HtmlAgilityPack library for HTML manipulation.
  * Install via NuGet Package Manager:
        Install-Package HtmlAgilityPack
## Usage
1. **Run the Application:**

* The application will prompt you to select the HTML file containing the image carousel.
2. **Select Output Folder:**

* Choose the output folder where the modified HTML file will be saved.
## View Results:

* After processing, the application saves a new HTML file with the images in reverse order in the specified output folder.


## Requirements
.NET 5.0 or later (configured for Windows Forms support).

## License
This project is provided under the MIT License.
