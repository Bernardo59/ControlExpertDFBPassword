"""
***************************************
  Find password in Control Expert DFB
***************************************
"""

from PySide2 import QtWidgets, QtGui, QtCore

# init
ascii_table = {
    0: " ",
    1: "!",
    2: '"',
    3: "#",
    4: "$",
    5: "%",
    6: "&",
    7: "'",
    8: "(",
    9: ")",
    10: "*",
    11: "+",
    12: ",",
    13: "-",
    14: ".",
    15: "/",
    16: "0",
    17: "1",
    18: "2",
    19: "3",
    20: "4",
    21: "5",
    22: "6",
    23: "7",
    24: "8",
    25: "9",
    26: ":",
    27: ";",
    28: "<",
    29: "=",
    30: ">",
    31: "?",
    32: "@",
    33: "A",
    34: "B",
    35: "C",
    36: "D",
    37: "E",
    38: "F",
    39: "G",
    40: "H",
    41: "I",
    42: "J",
    43: "K",
    44: "L",
    45: "M",
    46: "N",
    47: "O",
    48: "P",
    49: "Q",
    50: "R",
    51: "S",
    52: "T",
    53: "U",
    54: "V",
    55: "W",
    56: "X",
    57: "Y",
    58: "Z",
    59: "[",
    60: "\\",
    61: "]",
    62: "^",
    63: "_",
    64: "`",
    65: "a",
    66: "b",
    67: "c",
    68: "d",
    69: "e",
    70: "f",
    71: "g",
    72: "h",
    73: "i",
    74: "j",
    75: "k",
    76: "l",
    77: "m",
    78: "n",
    79: "o",
    80: "p",
    81: "q",
    82: "r",
    83: "s",
    84: "t",
    85: "u",
    86: "v",
    87: "w",
    88: "x",
    89: "y",
    90: "z",
    91: "{",
    92: "|",
    93: "}",
    94: "~",
}


# Create class for QtWidgets on PySide2
class App(QtWidgets.QWidget):
    pwd = ""

    # init class
    def __init__(self):
        # super() replace QtWidgets.QWidget.__init__()
        super().__init__()
        self.setWindowTitle("Find password in Control Expert DFB - Biloute")
        self.setFixedWidth(450)
        self.setup_ui()
        self.set_connections()
        self.default_values()

    # setup form
    def setup_ui(self):
        # create widgets
        self.layout = QtWidgets.QVBoxLayout(self)
        self.img_schneider = QtGui.QPixmap("assets/schneider.jpg")
        self.lbl_schneider = QtWidgets.QLabel()
        self.lbl_password = QtWidgets.QLabel("Type password discovered in 'PathBase.db':")
        self.txt_password = QtWidgets.QLineEdit()
        self.btn_search = QtWidgets.QPushButton("Find")
        self.area_passwords = QtWidgets.QTextEdit()
        # add widgets in layout
        self.layout.addWidget(self.lbl_schneider)
        self.layout.addWidget(self.lbl_password)
        self.layout.addWidget(self.txt_password)
        self.layout.addWidget(self.btn_search)
        self.layout.addWidget(self.area_passwords)

    # set widgets values
    def default_values(self):
        font_button = QtGui.QFont("Helvetica", 10, QtGui.QFont.Bold)
        font_label = QtGui.QFont("Helvetica", 10)
        font_label.setUnderline(True)
        self.lbl_schneider.setPixmap(self.img_schneider)
        self.txt_password.setAlignment(QtCore.Qt.AlignCenter)
        self.txt_password.setMaxLength(12)
        self.lbl_schneider.setAlignment(QtCore.Qt.AlignCenter)
        self.txt_password.setToolTip("Enter Password")
        self.txt_password.setDragEnabled(False)
        self.btn_search.setFont(font_button)
        self.btn_search.setToolTip("Find passwords!")
        self.lbl_password.setFont(font_label)
        # hide area passwords
        self.area_passwords.setFixedHeight(300)
        self.area_passwords.setVisible(False)

    # set event
    def set_connections(self):
        self.txt_password.textChanged.connect(self.password_value)
        self.btn_search.clicked.connect(self.clicked_password)

    # event password value
    def password_value(self):
        self.pwd = self.txt_password.text()

    # event clicked find password
    def clicked_password(self):
        text_passwords = ""
        passwords = (find_passwords(self.pwd))
        self.area_passwords.setVisible(True)
        text_passwords += f"Possible password: \n1 - {passwords[7]}\n2 - {passwords[8]}\n" \
                          f"3 - {passwords[14]}\n4 - {passwords[15]} \n\r"
        text_passwords += "**************************************** \n"
        text_passwords += "If the possible passwords doesn't match, try them: \n"
        for count, value in enumerate(passwords):
            text_passwords += str(count) + " - " + value + "\n"
        # show list of passwords possible
        self.area_passwords.setText(text_passwords)


# function find passwords
def find_passwords(password):
    # init vars
    j = 1
    decrypted_password_neg = ""
    decrypted_password_pos = ""
    table_password = []
    # program
    password_list = password
    # iterate
    while j < 10:
        for f in password_list:
            for i, y in ascii_table.items():
                if f == "0":
                    decrypted_password_pos += "0"
                    decrypted_password_neg += "0"
                    break
                if f == y:
                    if int(i) - j > 0:
                        decrypted_password_neg += ascii_table[int(i) - j]
                    else:
                        decrypted_password_neg += ascii_table[len(ascii_table) - int(i) - j]

                    if int(i) + j < len(ascii_table):
                        decrypted_password_pos += ascii_table[int(i) + j]
                    else:
                        decrypted_password_neg += ascii_table[int(i) + j - len(ascii_table)]
        # append password
        table_password.append(decrypted_password_neg)
        table_password.append(decrypted_password_pos)
        # raz password
        decrypted_password_neg = ""
        decrypted_password_pos = ""
        # increment
        j += 1
    return table_password


if __name__ == "__main__":
    app = QtWidgets.QApplication([])
    win = App()
    win.show()
    app.exec_()

