Imports System.Drawing.Imaging

Public Class frmImageModifier
    Dim myImage As Bitmap

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        'construct OpenFileDialog object from OpenFileDialog class
        'to launch open file dialog window
        Dim open As New OpenFileDialog
        'value of the title property
        '   determines caption of open file dialog window
        open.Title = "Image Location"

        'assign a filter string to the filter property of the object
        'filter string has list of filtering options displayed
        'each option represents a filetype
        'each option is made of:
        '   1) a filter description
        '   2) a vertical bar (|)
        '   3) the filter pattern
        'number of vertical bars = number of filters
        open.Filter = "JPeg Image|*.jpg|All files (*.*)|*.*"

        'if condition serves two purposes here:
        '   1) display open file dialog window
        '   2) check if user clicks Open button
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'filename is a string containing directory of selected image and its name
            'the right of the assignment operator constructs an object
            '   from the bitmap class, the obj contains a selected image
            '"=" assignes the new object to myImage.
            'now, originalImage contains the selected image.
            myImage = New Bitmap(open.FileName, True)
            'the statement below removes borders of left picture box
            picOriginal.BorderStyle = BorderStyle.None
            'the statement below displays selected image in left picture box
            picOriginal.Image = myImage
            'if there's image displayed in right picture box coming from
            '   the last conversion, the statement below clears off that pic
            picConverted.Image = Nothing
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'if user click save button with an image
        '   converted and displayed in right picturebox,
        '   the if condition is true.
        If picConverted.Image IsNot Nothing Then
            Dim save As New SaveFileDialog
            save.Title = "Save Directory"
            'the statement below assigns a filter string to the filter property
            save.Filter = "JPeg Image|*.jpg|All files (*.*)|*.*"
            'the below if condition serves two purposes:
            '   1) it displays the save dialog window
            '   2)it checks if user clicks the Save Button
            If save.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'the below statement uses the Save method
                '   to save the converted pic to a directory
                '   specified in the save dialog window
                picConverted.Image.Save(save.FileName)
                MessageBox.Show("Converted image saved successfully!")
            End If
        Else
            'if user clicks the save button without image
            '   converted and displayed in the right picturebox, 
            '   the below message is displayed: 
            MessageBox.Show("No image to be saved.", "Error")
        End If
    End Sub

    Private Sub UseMonochrome(imgToProcess As Bitmap)
        Dim r, g, b, average As Integer
        Dim y, x As Integer
        Dim newColor As Color

        For y = 0 To imgToProcess.Height - 1
            For x = 0 To imgToProcess.Width - 1
                Dim pixelColor As Color = imgToProcess.GetPixel(x, y)
                r = CInt(pixelColor.R)
                g = CInt(pixelColor.G)
                b = CInt(pixelColor.B)

                average = CInt((r + g + b) / 3)

                If average > 128 Then
                    newColor = Color.FromArgb(255, 255, 255)
                Else
                    newColor = Color.FromArgb(0, 0, 0)
                End If

                imgToProcess.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    Private Sub UseGrayAveraging(imgToProcess As Bitmap)
        Dim r, g, b As Integer
        Dim y, x As Integer
        Dim newColor As Color
        Dim grey As Integer

        For y = 0 To imgToProcess.Height - 1
            For x = 0 To imgToProcess.Width - 1
                Dim pixelColor As Color = imgToProcess.GetPixel(x, y)
                r = CInt(pixelColor.R)
                g = CInt(pixelColor.G)
                b = CInt(pixelColor.B)

                grey = CInt((r + (g + b)) / 3)

                newColor = Color.FromArgb(grey, grey, grey)
                imgToProcess.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    Private Sub UseLuma(imgToProcess As Bitmap)
        Dim r, g, b As Integer
        Dim y, x As Integer
        Dim newColor As Color
        Dim grey As Integer

        For y = 0 To imgToProcess.Height - 1
            For x = 0 To imgToProcess.Width - 1
                Dim pixelColor As Color = imgToProcess.GetPixel(x, y)
                r = CInt(pixelColor.R)
                g = CInt(pixelColor.G)
                b = CInt(pixelColor.B)

                grey = CInt(r * 0.2126 + g * 0.7152 + b * 0.0722)

                newColor = Color.FromArgb(grey, grey, grey)
                imgToProcess.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    Private Sub UseDesaturation(imgToProcess As Bitmap)
        Dim r, g, b As Integer
        Dim y, x As Integer
        Dim newColor As Color
        Dim grey As Integer

        For y = 0 To imgToProcess.Height - 1
            For x = 0 To imgToProcess.Width - 1
                Dim pixelColor As Color = imgToProcess.GetPixel(x, y)
                r = CInt(pixelColor.R)
                g = CInt(pixelColor.G)
                b = CInt(pixelColor.B)

                grey = CInt((Math.Max(Math.Max(r, g), b) + Math.Min(Math.Min(r, g), b)) / 2)


                newColor = Color.FromArgb(grey, grey, grey)
                imgToProcess.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    Private Sub UseMaxDecomposition(imgToProcess As Bitmap)
        Dim r, g, b As Integer
        Dim y, x As Integer
        Dim newColor As Color
        Dim grey As Integer

        For y = 0 To imgToProcess.Height - 1
            For x = 0 To imgToProcess.Width - 1
                Dim pixelColor As Color = imgToProcess.GetPixel(x, y)
                r = CInt(pixelColor.R)
                g = CInt(pixelColor.G)
                b = CInt(pixelColor.B)

                grey = Math.Max(Math.Max(r, g), b)


                newColor = Color.FromArgb(grey, grey, grey)
                imgToProcess.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    Private Sub UseMinDecomposition(imgToProcess As Bitmap)
        Dim r, g, b As Integer
        Dim y, x As Integer
        Dim newColor As Color
        Dim grey As Integer

        For y = 0 To imgToProcess.Height - 1
            For x = 0 To imgToProcess.Width - 1
                Dim pixelColor As Color = imgToProcess.GetPixel(x, y)
                r = CInt(pixelColor.R)
                g = CInt(pixelColor.G)
                b = CInt(pixelColor.B)

                grey = Math.Min(Math.Min(r, g), b)


                newColor = Color.FromArgb(grey, grey, grey)
                imgToProcess.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    'problem child function::: system argument exception
    Private Sub UseSingleColorChannel(imgToProcess As Bitmap)
        Dim r, g, b As Integer
        Dim y, x As Integer
        Dim newColor As Color
        Dim grey As Integer

        For y = 0 To imgToProcess.Height - 1
            For x = 0 To imgToProcess.Width - 1
                Dim pixelColor As Color = imgToProcess.GetPixel(x, y)
                r = CInt(pixelColor.R)
                g = CInt(pixelColor.G)
                b = CInt(pixelColor.B)

                grey = r
                grey = g
                grey = b

                newColor = Color.FromArgb(grey, grey, grey)
                imgToProcess.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'this if statement evaluates if there's an image to convert in the left pic box.
        If picOriginal.Image IsNot Nothing Then

            'this if statement evaluates if user has selected a filter to convert the image
            If cboFilter.SelectedItem IsNot Nothing Then
                myImage = New Bitmap(picOriginal.Image)
                'if user has selected a filter to convert the image,
                'the select case statement evaluates which filter is selected
                Select Case cboFilter.SelectedIndex
                    Case 0
                        'Monochrome
                        UseMonochrome(myImage)
                    Case 1
                        'gray - averaging
                        UseGrayAveraging(myImage)
                    Case 2
                        'Luma
                        UseLuma(myImage)
                    Case 3
                        'Desaturation
                        UseDesaturation(myImage)
                    Case 4
                        'Maximum Decomposition
                        UseMaxDecomposition(myImage)
                    Case 5
                        'Minimum Decomposition
                        UseMinDecomposition(myImage)
                    Case 6
                        'Single Color Channel
                        UseSingleColorChannel(myImage)
                End Select

                picConverted.Image = myImage
                picConverted.BorderStyle = BorderStyle.None
            Else
                MessageBox.Show("select a filter to work with", "Error")
            End If
        Else
            MessageBox.Show("select a picture to convert", "Error")
        End If
    End Sub
End Class
