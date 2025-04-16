import { useState } from "react";
import ButtonDelete from "../../shared/components/Buttons/ButtonDelete";
import ButtonDetail from "../../shared/components/Buttons/ButtonDetail";
import { Direction } from "../../shared/components/OffCanvas/Models";
import OffCanvas from "../../shared/components/OffCanvas/Index";
import { QuarterlyCutsForm } from "./QuarterlyCutsForm";
export const QuarterlyCuts = () => {
    const [visible, setVisible] = useState(false);

    const hadbleClick = () => {
        setVisible(true);
    }

    
    const handleClose = () => {
        setVisible(false);
    }

    return (
        <div className="flex-1 p-8">
            <div className="">
                <div className="flex items-center space-x-4">
                    <span className="font-medium">IPS</span>
                    <select className="border rounded px-3 py-1">
                        <option>HOSPITAL SAN SEBASTIAN</option>
                    </select>
                </div>

            </div>
            <h1 className="text-2xl font-semibold mb-4">Cortes trimestrales de auditoria</h1>
            <button onClick={hadbleClick} className="bg-indigo-500 hover:bg-indigo-900 text-white px-6 py-2 rounded-lg font-semibold mb-2">
                Crear Corte Trimestral
            </button>

            <div>
                <div className="grid grid-cols-5">
                    <div className="gap-3 font-semibold bg-gray-300  text-gray-800 px-2 py-1">Nombre</div>
                    <div className="gap-3 font-semibold bg-gray-300  text-gray-800 px-2 py-1">Máx Historias</div>
                    <div className="gap-3 font-semibold bg-gray-300  text-gray-800 px-2 py-1">Fecha Inicial</div>
                    <div className="gap-3 font-semibold bg-gray-300  text-gray-800 px-2 py-1">Fecha Final</div>
                    <div className="gap-3 font-semibold bg-gray-300  text-gray-800 px-2 py-1 text-center">Opciones</div>
                </div>

                <div className="bg-white px-2 py-2 border border-gray-200">
                    <div className="grid grid-cols-5">
                        <div className=" gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">1er Trimestre 2025</div>
                        <div className=" gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">220</div>
                        <div className=" gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">01-01-2025</div>
                        <div className=" gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">31-03-2025</div>
                        <div className=" flex justify-center"> 
                            <ButtonDelete id={0} onDelete={undefined}/>
                            <ButtonDetail url={"/InstrumentsDetail"} />
                        </div>
                    </div>
                </div>
                <OffCanvas titlePrincipal='Crear Cortes Trimestrales' visible={visible} xClose={handleClose} position={Direction.Right}  >
                    <QuarterlyCutsForm/>
                </OffCanvas>
            </div>
        </div>

    );
}