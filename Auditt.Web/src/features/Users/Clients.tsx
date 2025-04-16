import { useState } from "react";
import OffCanvas from "../../shared/components/OffCanvas/Index";
import { Direction } from "../../shared/components/OffCanvas/Models";
import { ClientCreate } from "./ClientCreate";
import ButtonDetail from "../../shared/components/Buttons/ButtonDetail";
import { LinkClients } from "../Dashboard/LinkClients";
import ButtonDelete from "../../shared/components/Buttons/ButtonDelete";
import { useClient } from "./useClient";
import { Bar } from "../../shared/components/Progress/Bar";
import { ClientUpdate } from "./ClientUpdate";
import { ClientModel } from "./ClientModel";
import { MouseEvent } from "react";
import Swal from "sweetalert2";
export const Clients = () => {
    const [visible, setVisible] = useState(false);
    const [visibleUpdate, setVisibleUpdate] = useState(false);
    const { clients, queryClients, deleteClient } = useClient();
    const [client, setClient] = useState<ClientModel>();


    const handleClickDetail = (clientSelected: ClientModel) => {
        if (clientSelected) {
            setClient(clientSelected);
            setVisibleUpdate(true);
        }
    }

    function handleDelete(e: MouseEvent<HTMLButtonElement>, id: number): void {
        e.preventDefault();
        Swal.fire({
            title: '¿Estás seguro de eliminar este cliente?',
            text: 'Esta acción no se puede deshacer',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            confirmButtonText: 'Confirmar',
            cancelButtonText: 'Cancelar',
            preConfirm: async () => {
                await deleteClient.mutateAsync(id);
            }
        })
    }

    if (queryClients.isLoading)
        return <Bar />

    return (
        <div className="flex p-8">
            <div>
                <div className="flex space-x-8 text-lg font-medium mb-6 mr-2">
                    <LinkClients />
                </div>

                <h2 className="text-2xl font-semibold mb-4">Clientes o Instituciones</h2>

                <button onClick={() => setVisible(true)} className="bg-indigo-500 hover:bg-indigo-900 text-white px-6 py-2 rounded-lg font-semibold mb-2">
                    Crear Clientes
                </button>
                <div>
                    <div className="grid grid-cols-5">
                        <div className=" font-semibold bg-gray-300  text-gray-800 px-2 py-1">Razón Social</div>
                        <div className=" font-semibold bg-gray-300  text-gray-800 px-2 py-1 ">Abreviatura</div>
                        <div className=" font-semibold bg-gray-300  text-gray-800 px-2 py-1">Nit</div>
                        <div className=" font-semibold bg-gray-300  text-gray-800 px-2 py-1">Ciudad</div>
                        <div className=" font-semibold bg-gray-300  text-gray-800 px-2 py-1 text-center">Opciones</div>
                    </div>

                    <div className=" bg-white px-2 py-2 border border-gray-200">
                        {clients?.map((client) => (
                            <div className="grid grid-cols-5">
                                <div className="gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">{client.name}</div>
                                <div className="gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">{client.abbreviation}</div>
                                <div className="gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">{client.nit}</div>
                                <div className="gap-3 text-sm bg-white px-2 py-2 border border-gray-300 mr-2">{client.city}</div>
                                <div className="flex justify-center">
                                    <ButtonDelete id={client.id ?? 0} onDelete={handleDelete} />
                                    <ButtonDetail url={""} xClick={() => handleClickDetail(client)} />
                                </div>
                            </div>
                        ))}
                    </div>

                </div>
                <OffCanvas titlePrincipal='Crear Cliente' visible={visible} xClose={() => setVisible(false)} position={Direction.Right}  >
                    <ClientCreate />
                </OffCanvas>
                {
                    client &&
                    <OffCanvas titlePrincipal='Detalle Cliente' visible={visibleUpdate} xClose={() => setVisibleUpdate(false)} position={Direction.Right}  >
                        <ClientUpdate data={client} />
                    </OffCanvas>
                }
            </div>
        </div>
    );
}