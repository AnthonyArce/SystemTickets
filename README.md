# Sistema de tickets

Tarea 

## Explicación de código

### Inicializo las variables globales
```C#
    int[] _asientos = new int[10]; // 0 libre - 1 reservado s/comida - 2 reservado
     c/comida
    List<Label> _labels;
    List<Color> _colores = new List<Color> { Color.Green, Color.Blue, Color.Red };
    int _asientoConComida = 0;
    int _asientosSinComida = 0;
    int _asientosDisponibles = 0;
```

**int[] _asientos = new int[10];**: Se está declarando un arreglo de enteros llamado `_asientos` con 10 elementos, lo que representa los 10 asientos disponibles. Cada elemento del arreglo tiene tres posibles valores:

-   `0`: El asiento está libre.
-   `1`: El asiento está reservado **sin comida**.
-   `2`: El asiento está reservado **con comida**.

```C#
    List<Label> _labels;
```

**List < Label > _labels:** Una lista de labels que contendra la referencia de cada labels
```C#
 List < Color > _colores = new List<Color> { Color.Green, Color.Blue, Color.Red };
 ``` 
 Es una lista de colores (`Color`) que contiene tres colores: Verde (`Green`), Azul (`Blue`) y Rojo (`Red`). Donde estos colores estan asociados con los diferentes estados de los asientos:

-   `Color.Green`: Asiento libre (estado `0`).
-   `Color.Blue`: Asiento reservado sin comida (estado `1`).
-   `Color.Red`: Asiento reservado con comida (estado `2`).

```C#
    int _asientoConComida = 0;
    int _asientosSinComida = 0;
    int _asientosDisponibles = 0;
```

-   **int _asientoConComida = 0**: Variable que cuenta el número de asientos reservados con comida.
-   **int _asientosSinComida = 0**: Variable que cuenta el número de asientos reservados sin comida.
-   **int _asientosDisponibles = 0**: Variable que cuenta el número de asientos disponibles (libres).

----- 
### Rellenado del Select (ComboText)

Cuando el formulario inicie vamos a cargar la cantidad de asientos que tenemos todos con estado 0 en un principio
```C#
 private void frmPrincipal_Load(object sender, EventArgs e)
 {
     cargarComboText(_asientos);
 }
 ```
```C#
         private void cargarComboText(int[] _asientos) 
        {
            cboNumAsientos.Items.Clear();
            chkConComida.Checked = false;
            cboNumAsientos.Text = "Seleccione un asiento";

            for (int i = 0; i < _asientos.Length; i++)
            {
                if (_asientos[i] == 0)
                    cboNumAsientos.Items.Add((i + 1).ToString());
            }
        }
```


---
### Logica de venta de un boleto

Cuando se oprime el boton vender sucede lo siguiente

```C#
private void btnVender_Click(object sender, EventArgs e)
{
    if (cboNumAsientos.Text != "Seleccione un asiento")
    {
        int asientoSeleccionado = int.Parse(cboNumAsientos.Text);
        bool conComida = chkConComida.Checked;

        if (conComida)
        {
            _asientos[asientoSeleccionado - 1] = 2;
            _asientoConComida++;
        }
        else
        {
            _asientos[asientoSeleccionado - 1] = 1;
            _asientosSinComida++;
        }

        _asientosDisponibles--;
        prbCapacidad.Value++;

        if(_asientosDisponibles == 0)
            btnVender.Enabled = false;

        ActualizarCampoVentas();
        actualizarCamposLbl(_asientosDisponibles, _asientoConComida, _asientosSinComida);
    }
    else
    {
        MessageBox.Show("Seleccione un asiento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}

```

----
### Manejo de colores de los asientos segun el estado

```C#
private void tabPage2_SelectedIndexChanged(object sender, EventArgs e)
{
    for (int i = 0; i < _asientos.Length; i++) 
    {
        _labels[i].BackColor = _colores[_asientos[i]];
    }
}
```
