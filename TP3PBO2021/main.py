from tkinter import *
from PIL import ImageTk, Image

root = Tk()
root.title("Window")

myLabel = Label(root, text="Judul Film:").grid(column=0, row=0)
merk = Entry(root, width=20, borderwidth=5)
merk.insert(0, "")
merk.grid(column=1, row=0)

myLabel = Label(root, text="Pemeran:").grid(column=0, row=1)
seri = Entry(root, width=20, borderwidth=5)
seri.insert(0, "")
seri.grid(column=1, row=1)

myLabel = Label(root, text="Sutradara:").grid(column=0, row=2)
harga = Entry(root, width=20, borderwidth=5)
harga.insert(0, "")
harga.grid(column=1, row=2)

myLabel = Label(root, text="Tahun:").grid(column=0, row=3)
harga = Entry(root, width=20, borderwidth=5)
harga.insert(0, "")
harga.grid(column=1, row=3)

myLabel = Label(root, text="Genre:").grid(column=0, row=4)
options = [
    "Romance",
    "Action",
    "Adventure",
    "Horror",
]

ram = StringVar()
ram.set(options[0])

drop = OptionMenu(root, ram, *options)
drop.grid(column=1, row=4)

myLabel = Label(root, text="Aksesoris:").grid(column=0, row=5)
var1 = StringVar()

aksesoris = Checkbutton(root, text="Charger", variable=var1, onvalue = "Charger", offvalue="")
aksesoris.deselect()
aksesoris.grid(column=3, row=5, columnspan=1)

var2 = StringVar()

aksesoris = Checkbutton(root, text="Case", variable=var2, onvalue = "Case", offvalue="")
aksesoris.deselect()
aksesoris.grid(column=2, row=5, columnspan=1)

var3 = StringVar()

aksesoris = Checkbutton(root, text="Tempered Glass", variable=var3, onvalue = "Tempered Glass", offvalue="")
aksesoris.deselect()
aksesoris.grid(column=1, row=5, columnspan=1)

myLabel = Label(root, text="Warna:").grid(column=0, row=6)

Colours = [
    ("Rose Gold", "Rose Gold"),
    ("Black", "Black"),
    ("White", "White"),
    ("Silver", "Silver")
]

colour = StringVar()
colour.set("")

i = 1
for text, colours, in Colours:
    Radiobutton(root, text=text, variable=colour, value=colours).grid(column=i, row=6)
    i = i + 1

myButton = Button(root, text="Open Photo File", command=Image, fg="Black", bg="#FFFFFF")
myButton.grid(column=2, row =7)

root.mainloop()