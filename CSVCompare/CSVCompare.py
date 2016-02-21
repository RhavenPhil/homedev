import csv
with open('E:\dev\CSVCompare\File1.csv', newline='') as f:
    reader = csv.reader(f)
    for row in reader:
        print(row)
with open('E:\dev\CSVCompare\File2.csv', newline='') as f:
    reader = csv.reader(f)
    for row in reader:
        print(row)