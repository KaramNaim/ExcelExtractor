ImportFiles.onchange = (e) => {
    console.log([...ImportFiles.files].map(file => file.name));

    let ArrayValues = new Array();

    let files = e.target.files;

    for (let i = 0; i < files.length; i++) {
        const reader = new FileReader();
        reader.onload = (event) => {
            const data = new Uint8Array(event.target.result);

            const workbook = XLSX.read(data, { type: "array" });

            const sheetName = workbook.SheetNames[0];

            console.log("sheetName :" + sheetName);

            const worksheet = workbook.Sheets[sheetName];

            console.log("worksheet :" + worksheet);

            const cellA1 = worksheet["A1"];
            const value = cellA1 ? cellA1.v : "";

            console.log("Value :" + value);
            console.log("-----------------------------------------------------------------------");

            ArrayValues.push(value);
            console.log("Array :" + ArrayValues);
        };
        reader.readAsArrayBuffer(files[i]);

        
    };
};