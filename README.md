# Image-To-ASCII
Convert images to ASCII art

## Description
To automate the creation ASCII art by passing :an image, ASCII Style(explained in the ASCIISTYLE section) and the number of desired characters through to an algorithm that takes those inputs and outputs ASCII art.

## Guides
### How To Open The Application
- For the .exe go to "C:\\ImageToAsciiConverterDesktop\UserInterface\bin\Debug\net5.0-windowsUserInterface.exe"
- I reccomend you create a shortcut with right click and "Create Shortcut" if youre going to use this frequently

### How To Use The Application
1. Click Upload :
### ![image](https://user-images.githubusercontent.com/69385515/121937856-6a9f5400-cd4b-11eb-9bae-8b4928cdc9db.png)
2. Select an image :
### ![image](https://user-images.githubusercontent.com/69385515/121938040-a1756a00-cd4b-11eb-8603-0ec62e7b5505.png)
3. Click convert :
### ![image](https://user-images.githubusercontent.com/69385515/121938301-eac5b980-cd4b-11eb-94f1-91b3f5e4b7f0.png)
4. Carry on with your day :
### ![image](https://user-images.githubusercontent.com/69385515/121939115-e9e15780-cd4c-11eb-806d-0e072419ef62.png)


### Features
#### Characters Per Line
###  ![image](https://user-images.githubusercontent.com/69385515/121940143-0d58d200-cd4e-11eb-8bbe-022c52e651e0.png)
- It's self explanatory, you can write how many ASCII characters you want per line.
- The number of outputted lines is determined by the number of characters per line * the images aspect ratio.
- The conversion algorithm splits the image into segments, and the number of pieces the image is segmented into is directly proportional to the number of characters to be output.

#### Ascii Style
### ![image](https://user-images.githubusercontent.com/69385515/121941777-f9ae6b00-cd4f-11eb-944f-a9634d1c53d4.png)
- The way the program turns images into ASCII art is by segmenting the image, checking the average gray/luminance value of each segments and outputting the corresponding character.
- The characters to be used are determined by this element, think of it as a colour palette.
- For example, if the average gray/luminance value(which is a byte value meaning min is 0 and max is 255) of a segment is 255(which would be pure white) the character under the lightest part of the gradient will be selected to represent that segment, in this case it would be a '@'
- You can tell the range of lightness characters each character represents by the range above it 
- The values between the red lines would be represented by '#' ![image](https://user-images.githubusercontent.com/69385515/121942729-19925e80-cd51-11eb-9300-d9d0f3128120.png)
- You increase the range of values each character represents by removing the rightmost character by clicking the [-] button ![image](https://user-images.githubusercontent.com/69385515/121942991-67a76200-cd51-11eb-9126-72018af081a1.png)
- The inverse is done bt clicking the [+] button ![image](https://user-images.githubusercontent.com/69385515/121943072-7db52280-cd51-11eb-90d2-ee747df3ef37.png)

### More Options
#### ![image](https://user-images.githubusercontent.com/69385515/121943358-ca006280-cd51-11eb-8244-aef8461afab1.png)
- As of writing this clicking on more options element reveals and enables the contrast boost feature.
#### Contrast Boost
#### ![image](https://user-images.githubusercontent.com/69385515/121943385-d1277080-cd51-11eb-9146-5f2ff09650f3.png)
- Boosts the contrast of the image from 0 up to a value of 100(can not lower contrast below the images original)

### Hidden Features
- Mousing over the gradient in AsciiStyle allows you to flip the gradient essentially inverting the final ASCII art image.
- Ctrl + Plus will zoom in on the ascii art.
- Ctrl + Minus will zoom out of the ascii art.

## Known Issues
- going above 200 characters per line the final image can be cropped.
- going above 700 characters per line the application can crash.
- going under 50 characters per line can make the output ASCII art only show 1 character type.
- when clicking convert the program goes unresponsive depending on the images resolution.(this is because when writing the code I didn't understand asynchronous programming so the application freezes when processing the image)

## Ending Notes
- I hope you find it easy enough to adapt the code to what you want, I'd hope you let me know what you use it on.
- You can upgrade and improve the code if you want and i will add it to a branch for the comunity to work on.
- Thanks for reading.
