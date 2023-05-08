# pCloud Uploader
a sample application showing how to upload a file to pCloud and get a public link to that file

A unit test in the project takes a local `mytestfile.txt` file and uploads it to the specified folder in pCloud. Then it returns a public link to that file.

## Settings File

The settings file is a JSON file with the following structure:

```json
    "Test": {
        "User": "YOUR_PCLOUD_USERNAME",
        "Password": "YOUR_PCLOUD_PASSWORD",
        "PCloudFolder": "PublicPictures",
        "LocalFileToUpload": ".\\TestFiles\\mytestfile.txt"
    }
```

update the values to match your pCloud account and the folder you want to upload the file to.