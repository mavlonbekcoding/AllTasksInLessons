using TestShifr;

FileEncryption fileEncryption = new FileEncryption();
await fileEncryption.EncryptFileAsync("D:\\NT Level2\\AllTasksInLessons\\TestFile\\Test.txt", "D:\\NT Level2\\AllTasksInLessons\\TestFile\\ResultText.txt", "1514");
